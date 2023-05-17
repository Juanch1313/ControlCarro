using System.Net.Sockets;
using System.Text;

namespace ControlCarro;

public partial class MainPage : ContentPage
{
    private string esp32IpAddress = "187.212.243.94";
    private int esp32Port = 80;
    TcpClient client = new TcpClient();
    NetworkStream stream;


    public MainPage()
	{
		InitializeComponent();
        BtnDisconect.IsVisible = false;
    }

    private void BtnUp_Clicked(object sender, EventArgs e)
    {
        try
        {

            string signal = "d";
            byte[] data = Encoding.UTF8.GetBytes(signal);


            stream.Write(data, 0, data.Length);

        }
        catch (Exception ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }
    }

    private void BtnDown_Clicked(object sender, EventArgs e)
    {
        try
        {

            string signal = "a";
            byte[] data = Encoding.UTF8.GetBytes(signal);

            stream.Write(data, 0, data.Length);
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }
    }

    private void BtnLeft_Clicked(object sender, EventArgs e)
    {
        try
        {

            string signal = "s";
            byte[] data = Encoding.UTF8.GetBytes(signal);

            stream.Write(data, 0, data.Length);

        }
        catch (Exception ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }
    }

    private void BtnRight_Clicked(object sender, EventArgs e)
    {
        try
        {
            string signal = "w";
            byte[] data = Encoding.UTF8.GetBytes(signal);


            stream.Write(data, 0, data.Length);
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }
    }

    private void BtnQuit_Clicked(object sender, EventArgs e)
    {
        try
        {
            string signal = "q";
            byte[] data = Encoding.UTF8.GetBytes(signal);


            stream.Write(data, 0, data.Length);

        }
        catch (Exception ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }
    }

    private void BtnConnect_Clicked(object sender, EventArgs e)
    {
        client.Connect(esp32IpAddress, esp32Port);
        stream = client.GetStream();
        BtnConnect.IsVisible = false;
        BtnDisconect.IsVisible = true;
    }

    private void BtnDisconect_Clicked(object sender, EventArgs e)
    {
        stream.Close();
        client.Close();
        BtnConnect.IsVisible = true;
        BtnDisconect.IsVisible = false;
    }

    private void BtnUp_Released(object sender, EventArgs e)
    {
        try
        {
            string signal = "q";
            byte[] data = Encoding.UTF8.GetBytes(signal);


            stream.Write(data, 0, data.Length);

        }
        catch (Exception ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }
    }
}

