namespace VotingApp
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            radioPizza = new RadioButton();
            radioBurger = new RadioButton();
            radioSushi = new RadioButton();
            btnVote = new Button();
            lblResult = new Label();
            progressPizza = new ProgressBar();
            progressBurger = new ProgressBar();
            progressSushi = new ProgressBar();
            lblTitle = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(radioPizza);
            groupBox1.Controls.Add(radioBurger);
            groupBox1.Controls.Add(radioSushi);
            groupBox1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            groupBox1.ForeColor = Color.DarkSlateGray;
            groupBox1.Location = new Point(30, 70);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(350, 170);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Pilih Makanan Favorit";
            // 
            // radioPizza
            // 
            radioPizza.AutoSize = true;
            radioPizza.Font = new Font("Segoe UI", 11F);
            radioPizza.Location = new Point(20, 40);
            radioPizza.Name = "radioPizza";
            radioPizza.Size = new Size(103, 29);
            radioPizza.TabIndex = 0;
            radioPizza.TabStop = true;
            radioPizza.Text = "🍕 Pizza";
            radioPizza.UseVisualStyleBackColor = true;
            // 
            // radioBurger
            // 
            radioBurger.AutoSize = true;
            radioBurger.Font = new Font("Segoe UI", 11F);
            radioBurger.Location = new Point(20, 75);
            radioBurger.Name = "radioBurger";
            radioBurger.Size = new Size(116, 29);
            radioBurger.TabIndex = 1;
            radioBurger.TabStop = true;
            radioBurger.Text = "🍔 Burger";
            radioBurger.UseVisualStyleBackColor = true;
            // 
            // radioSushi
            // 
            radioSushi.AutoSize = true;
            radioSushi.Font = new Font("Segoe UI", 11F);
            radioSushi.Location = new Point(20, 110);
            radioSushi.Name = "radioSushi";
            radioSushi.Size = new Size(104, 29);
            radioSushi.TabIndex = 2;
            radioSushi.TabStop = true;
            radioSushi.Text = "🍣 Sushi";
            radioSushi.UseVisualStyleBackColor = true;
            // 
            // btnVote
            // 
            btnVote.BackColor = Color.MediumSeaGreen;
            btnVote.FlatStyle = FlatStyle.Flat;
            btnVote.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnVote.ForeColor = Color.White;
            btnVote.Location = new Point(30, 260);
            btnVote.Name = "btnVote";
            btnVote.Size = new Size(120, 45);
            btnVote.TabIndex = 2;
            btnVote.Text = "✅ Vote";
            btnVote.UseVisualStyleBackColor = false;
            btnVote.Click += btnVote_Click;
            // 
            // lblResult
            // 
            lblResult.AutoSize = true;
            lblResult.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblResult.ForeColor = Color.DarkSlateBlue;
            lblResult.Location = new Point(30, 330);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(195, 28);
            lblResult.TabIndex = 3;
            lblResult.Text = "Hasil Sementara : 0";
            // 
            // progressPizza
            // 
            progressPizza.Location = new Point(400, 80);
            progressPizza.Name = "progressPizza";
            progressPizza.Size = new Size(250, 25);
            progressPizza.TabIndex = 4;
            // 
            // progressBurger
            // 
            progressBurger.Location = new Point(400, 120);
            progressBurger.Name = "progressBurger";
            progressBurger.Size = new Size(250, 25);
            progressBurger.TabIndex = 5;
            // 
            // progressSushi
            // 
            progressSushi.Location = new Point(400, 160);
            progressSushi.Name = "progressSushi";
            progressSushi.Size = new Size(250, 25);
            progressSushi.TabIndex = 6;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblTitle.ForeColor = Color.DarkSlateBlue;
            lblTitle.Location = new Point(30, 20);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(445, 37);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Voting Makanan Favorit 🍔🍣🍕";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(720, 450);
            Controls.Add(lblTitle);
            Controls.Add(groupBox1);
            Controls.Add(btnVote);
            Controls.Add(lblResult);
            Controls.Add(progressPizza);
            Controls.Add(progressBurger);
            Controls.Add(progressSushi);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Form1";
            Text = "Voting Polling App";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioPizza;
        private System.Windows.Forms.RadioButton radioBurger;
        private System.Windows.Forms.RadioButton radioSushi;
        private System.Windows.Forms.Button btnVote;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.ProgressBar progressPizza;
        private System.Windows.Forms.ProgressBar progressBurger;
        private System.Windows.Forms.ProgressBar progressSushi;
        private System.Windows.Forms.Label lblTitle;
    }
}
