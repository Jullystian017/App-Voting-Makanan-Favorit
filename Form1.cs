using System;
using System.Windows.Forms;

namespace VotingApp
{
    public partial class Form1 : Form
    {
        // Variabel untuk nyimpen jumlah vote
        private int countPizza = 0;
        private int countBurger = 0;
        private int countSushi = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnVote_Click(object sender, EventArgs e)
        {
            // Cek pilihan user
            if (radioPizza.Checked)
            {
                countPizza++;
            }
            else if (radioBurger.Checked)
            {
                countBurger++;
            }
            else if (radioSushi.Checked)
            {
                countSushi++;
            }
            else
            {
                MessageBox.Show("Silakan pilih salah satu makanan dulu!",
                    "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Hitung total suara
            int totalVotes = countPizza + countBurger + countSushi;

            // Update progress bar (0–100%)
            if (totalVotes > 0)
            {
                progressPizza.Value = (int)((double)countPizza / totalVotes * 100);
                progressBurger.Value = (int)((double)countBurger / totalVotes * 100);
                progressSushi.Value = (int)((double)countSushi / totalVotes * 100);
            }

            // Update label hasil
            lblResult.Text = $"Hasil Sementara : " +
                             $"🍕 Pizza = {countPizza}, " +
                             $"🍔 Burger = {countBurger}, " +
                             $"🍣 Sushi = {countSushi}";
        }
    }
}
