using WMPLib;
namespace Wurfel



{
    
    public class Probe { 
    
   
        

        public int GetDiceWert()
        {
            Random random = new Random();
            int win = random.Next(1, 7);
            return win;
        }

        private void SetSite(int ergebnis, PictureBox pictureBox)
        {
            switch (ergebnis)
            {
                case 1:
                    try
                    {
                        pictureBox.Image = System.Drawing.Image.FromFile("C:\\Users\\OkraszewT\\Source\\Repos\\egorusegorus\\Wurfel\\1.jpg");

                    }
                    catch (FileNotFoundException ex)
                    {

                        MessageBox.Show($"Datei nicht gefunden: {ex.FileName}");
                    }
                    catch (Exception ex)
                    {

                        MessageBox.Show($"Fehler: {ex.Message}");
                    }
                    break;


                case 2:
                    try
                    {
                        pictureBox.Image = System.Drawing.Image.FromFile("C:\\Users\\OkraszewT\\Source\\Repos\\egorusegorus\\Wurfel\\2.jpg");

                    }
                    catch (FileNotFoundException ex)
                    {

                        MessageBox.Show($"Datei nicht gefunden: {ex.FileName}");
                    }
                    catch (Exception ex)
                    {

                        MessageBox.Show($"Fehler: {ex.Message}");
                    }
                    break;

                case 3:
                    try
                    {
                        pictureBox.Image = System.Drawing.Image.FromFile("C:\\Users\\OkraszewT\\Source\\Repos\\egorusegorus\\Wurfel\\3.jpg");

                    }
                    catch (FileNotFoundException ex)
                    {

                        MessageBox.Show($"Datei nicht gefunden: {ex.FileName}");
                    }
                    catch (Exception ex)
                    {

                        MessageBox.Show($"Fehler: {ex.Message}");
                    }
                    break;

                case 4:
                    try
                    {
                        pictureBox.Image = System.Drawing.Image.FromFile("C:\\Users\\OkraszewT\\Source\\Repos\\egorusegorus\\Wurfel\\4.jpg");

                    }
                    catch (FileNotFoundException ex)
                    {

                        MessageBox.Show($"Datei nicht gefunden: {ex.FileName}");
                    }
                    catch (Exception ex)
                    {

                        MessageBox.Show($"Fehler: {ex.Message}");
                    }
                    break;


                case 5:
                    try
                    {
                        pictureBox.Image = System.Drawing.Image.FromFile("C:\\Users\\OkraszewT\\Source\\Repos\\egorusegorus\\Wurfel\\5.jpg");

                    }
                    catch (FileNotFoundException ex)
                    {

                        MessageBox.Show($"Datei nicht gefunden: {ex.FileName}");
                    }
                    catch (Exception ex)
                    {

                        MessageBox.Show($"Fehler: {ex.Message}");
                    }
                    break;

                case 6:
                    try
                    {
                        pictureBox.Image = System.Drawing.Image.FromFile("C:\\Users\\OkraszewT\\Source\\Repos\\egorusegorus\\Wurfel\\6.jpg");

                    }
                    catch (FileNotFoundException ex)
                    {

                        MessageBox.Show($"Datei nicht gefunden: {ex.FileName}");
                    }
                    catch (Exception ex)
                    {

                        MessageBox.Show($"Fehler: {ex.Message}");
                    }
                    break;
                    

            }
        

        }

        public async void Animation(int ergebnis, PictureBox pictureBox)
        {



            WindowsMediaPlayer player = new WindowsMediaPlayer();
            player.URL = "C:\\Users\\OkraszewT\\Source\\Repos\\egorusegorus\\Wurfel\\d6.mp3";
            player.controls.play();

            /*
            pictureBox.Image = Image.FromFile("1.jpg");
            System.Threading.Thread.Sleep(3000);
            
            pictureBox.Image = Image.FromFile("2.jpg");
            System.Threading.Thread.Sleep(3000);
            
            pictureBox.Image = Image.FromFile("3.jpg");
            System.Threading.Thread.Sleep(3000);
            
            pictureBox.Image = Image.FromFile("4.jpg");
            System.Threading.Thread.Sleep(3000);
            
            pictureBox.Image = Image.FromFile("5.jpg");
            System.Threading.Thread.Sleep(3000);*/

            try
            {
                
                pictureBox.Image = System.Drawing.Image.FromFile("C:\\Users\\OkraszewT\\Source\\Repos\\egorusegorus\\Wurfel\\1.jpg");
                await Task.Delay(100); 

                pictureBox.Image = System.Drawing.Image.FromFile("C:\\Users\\OkraszewT\\Source\\Repos\\egorusegorus\\Wurfel\\2.jpg");
                await Task.Delay(100);

                pictureBox.Image = System.Drawing.Image.FromFile("C:\\Users\\OkraszewT\\Source\\Repos\\egorusegorus\\Wurfel\\3.jpg");
                await Task.Delay(100);

                pictureBox.Image = System.Drawing.Image.FromFile("C:\\Users\\OkraszewT\\Source\\Repos\\egorusegorus\\Wurfel\\4.jpg");
                await Task.Delay(100);

                pictureBox.Image = System.Drawing.Image.FromFile("C:\\Users\\OkraszewT\\Source\\Repos\\egorusegorus\\Wurfel\\6.jpg");
                await Task.Delay(100);

            }
            catch (FileNotFoundException ex)
            {
                
                MessageBox.Show($"Datei nicht gefunden: {ex.FileName}");
            }
            catch (Exception ex)
            {
                
                MessageBox.Show($"Fehler: {ex.Message}");
            }
           SetSite(ergebnis, pictureBox);
        }
        
    }

}
