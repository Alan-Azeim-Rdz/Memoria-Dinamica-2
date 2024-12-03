namespace Memoria_Dinamica_2
{
    public partial class Form1 : Form
    {
        int[] vector;
        int Y = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnSize_Click(object sender, EventArgs e)
        {
            try
            {
                int size = Convert.ToInt32(UpDowVectorSize.Text);
                if (size < 0)
                {
                    MessageBox.Show("Porfavor ingresa un numero diferente de 0 y que no sea menor a este");
                    return;
                }
                vector = new int[size];
                lblSize.Text = size.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("porfavor verifique los datos");
            }
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                int space = vector.Length - 1;
                int data = Convert.ToInt32(TexboxData.Text);
                vector[Y] = data;
                Y++;

                Array.Sort(vector);
                LstBoxVector.Items.Add(data);
            }
            catch (System.IndexOutOfRangeException)
            {
                MessageBox.Show("El vector ya esta lleno");
            }
            catch (System.NullReferenceException)
            {
                MessageBox.Show("Porfavor Primero creea el vector");
            }
            catch
            {
                MessageBox.Show("Verifica que tus datos sean correctos antes de agregarlos al arreglo");
            }
        }
    }
}
