using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

public class ZoomableLabel : Label
{
    private Image image;
    private bool zoomEnabled;

    [Browsable(true)]
    [Category("Appearance")]
    [Description("Define a imagem para exibição dentro do controle Label.")]
    public new Image Image
    {
        get { return image; }
        set
        {
            image = value;
            Refresh();
        }
    }

    [Browsable(true)]
    [Category("Behavior")]
    [Description("Indica se o redimensionamento automático da imagem está ativado.")]
    public bool ZoomEnabled
    {
        get { return zoomEnabled; }
        set
        {
            zoomEnabled = value;
            Refresh();
        }
    }

    protected override void OnPaint(PaintEventArgs e)
    {
        base.OnPaint(e);

        if (Image != null && ZoomEnabled)
        {
            // Calcula o tamanho da imagem redimensionada para se ajustar ao tamanho do Label
            Size scaledSize = GetScaledImageSize();

            // Calcula a posição da imagem para centralizá-la no Label
            Point position = new Point((Width - scaledSize.Width) / 2, (Height - scaledSize.Height) / 2);

            // Desenha a imagem redimensionada
            e.Graphics.DrawImage(Image, position.X, position.Y, scaledSize.Width, scaledSize.Height);
        }

        // Desenha o texto
        TextRenderer.DrawText(e.Graphics, Text, Font, ClientRectangle, ForeColor, BackColor, TextFormatFlags.VerticalCenter | TextFormatFlags.HorizontalCenter);
    }

    protected override void OnSizeChanged(EventArgs e)
    {
        base.OnSizeChanged(e);
        Refresh();
    }

    private Size GetScaledImageSize()
    {
        if (Image == null)
            return Size.Empty;

        float ratioX = (float)Width / Image.Width;
        float ratioY = (float)Height / Image.Height;
        float ratio = Math.Min(ratioX, ratioY);

        int scaledWidth = (int)(Image.Width * ratio);
        int scaledHeight = (int)(Image.Height * ratio);

        return new Size(scaledWidth, scaledHeight);
    }
}
