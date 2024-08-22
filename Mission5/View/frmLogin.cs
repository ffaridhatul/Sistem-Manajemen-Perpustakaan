using Mission5Lib.Model;
using System;
using System.Linq;
using System.Windows.Forms;

namespace Mission5
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            // Ambil nilai userId dan password dari input pengguna
            string userId = txtEmpNo.Text;
            string password = txtPassword.Text;

            using (var db = new DataContext())
            {
                // Cari pengguna di database berdasarkan LoginId dan Password
                var librarian = db.Librarians
                    .FirstOrDefault(l => l.LoginId == userId && l.Password == password);

                if (librarian != null)
                {
                    // Jika ditemukan, sembunyikan form login dan buka form utama
                    this.Hide();
                    frmMain mainForm = new frmMain(librarian); // Teruskan objek Librarian ke frmMain
                    mainForm.Show();
                }
                else
                {
                    // Jika tidak ditemukan, tampilkan pesan error
                    MessageBox.Show("ID / Password salah.", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            // Close the application
            Application.Exit();
        }
    }
}
