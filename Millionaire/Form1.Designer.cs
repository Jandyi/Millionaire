namespace Millionaire
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            listlevel = new ListBox();
            gamestart = new Button();
            withdrawbutton = new Button();
            labellevel = new Label();
            labelmoney = new Label();
            labelcurrent = new Label();
            LabelQuestion = new Label();
            switchquestion = new Button();
            fiftyfifty = new Button();
            AnswerB = new Button();
            AnswerA = new Button();
            AnswerD = new Button();
            AnswerC = new Button();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // listlevel
            // 
            listlevel.BackColor = SystemColors.Control;
            listlevel.Enabled = false;
            listlevel.Font = new Font("Segoe UI", 15F);
            listlevel.ForeColor = SystemColors.WindowText;
            listlevel.FormattingEnabled = true;
            listlevel.ItemHeight = 35;
            listlevel.Items.AddRange(new object[] { "$1.000.000", "$500.000", "$250.000", "$125.000", "$64.000", "$32.000", "$16.000", "$8.000", "$4.000", "$2.000", "$1.000", "$500", "$300", "$200", "$100" });
            listlevel.Location = new Point(911, 99);
            listlevel.Name = "listlevel";
            listlevel.Size = new Size(189, 529);
            listlevel.TabIndex = 0;
            // 
            // gamestart
            // 
            gamestart.BackColor = Color.FromArgb(20, 40, 80);
            gamestart.FlatAppearance.BorderColor = Color.DarkKhaki;
            gamestart.FlatAppearance.BorderSize = 2;
            gamestart.FlatStyle = FlatStyle.Flat;
            gamestart.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            gamestart.ForeColor = SystemColors.ButtonHighlight;
            gamestart.Location = new Point(908, 12);
            gamestart.Name = "gamestart";
            gamestart.Size = new Size(192, 72);
            gamestart.TabIndex = 1;
            gamestart.Text = "Start Game";
            gamestart.UseVisualStyleBackColor = false;
            gamestart.Click += gamestart_Click;
            // 
            // withdrawbutton
            // 
            withdrawbutton.BackColor = Color.FromArgb(20, 40, 80);
            withdrawbutton.Enabled = false;
            withdrawbutton.FlatAppearance.BorderColor = Color.DarkKhaki;
            withdrawbutton.FlatAppearance.BorderSize = 3;
            withdrawbutton.FlatStyle = FlatStyle.Flat;
            withdrawbutton.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            withdrawbutton.ForeColor = Color.White;
            withdrawbutton.Location = new Point(23, 551);
            withdrawbutton.Name = "withdrawbutton";
            withdrawbutton.Size = new Size(869, 77);
            withdrawbutton.TabIndex = 2;
            withdrawbutton.Text = "Withdraw";
            withdrawbutton.UseVisualStyleBackColor = false;
            withdrawbutton.Click += withdrawbutton_Click;
            // 
            // labellevel
            // 
            labellevel.AutoSize = true;
            labellevel.Font = new Font("Sylfaen", 13.2000008F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labellevel.ForeColor = Color.Gold;
            labellevel.Location = new Point(32, 16);
            labellevel.Name = "labellevel";
            labellevel.Size = new Size(98, 29);
            labellevel.TabIndex = 3;
            labellevel.Text = "Level :1";
            // 
            // labelmoney
            // 
            labelmoney.AutoSize = true;
            labelmoney.Font = new Font("Sylfaen", 13.2000008F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelmoney.ForeColor = Color.Gold;
            labelmoney.Location = new Point(362, 17);
            labelmoney.Name = "labelmoney";
            labelmoney.Size = new Size(39, 29);
            labelmoney.TabIndex = 3;
            labelmoney.Text = "$0";
            // 
            // labelcurrent
            // 
            labelcurrent.AutoSize = true;
            labelcurrent.Font = new Font("Sylfaen", 13.2000008F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelcurrent.ForeColor = Color.White;
            labelcurrent.Location = new Point(692, 16);
            labelcurrent.Name = "labelcurrent";
            labelcurrent.Size = new Size(39, 29);
            labelcurrent.TabIndex = 3;
            labelcurrent.Text = "$0";
            // 
            // LabelQuestion
            // 
            LabelQuestion.BackColor = Color.FromArgb(15, 25, 55);
            LabelQuestion.BorderStyle = BorderStyle.Fixed3D;
            LabelQuestion.Font = new Font("Sylfaen", 17F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LabelQuestion.ForeColor = Color.White;
            LabelQuestion.Location = new Point(32, 90);
            LabelQuestion.Name = "LabelQuestion";
            LabelQuestion.Size = new Size(848, 106);
            LabelQuestion.TabIndex = 3;
            LabelQuestion.Text = "Question";
            LabelQuestion.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // switchquestion
            // 
            switchquestion.BackColor = Color.FromArgb(20, 40, 80);
            switchquestion.Enabled = false;
            switchquestion.FlatAppearance.BorderColor = Color.DarkKhaki;
            switchquestion.FlatAppearance.BorderSize = 2;
            switchquestion.FlatStyle = FlatStyle.Flat;
            switchquestion.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            switchquestion.ForeColor = SystemColors.ButtonHighlight;
            switchquestion.Location = new Point(469, 230);
            switchquestion.Name = "switchquestion";
            switchquestion.Size = new Size(423, 54);
            switchquestion.TabIndex = 1;
            switchquestion.Text = "Switch Question";
            switchquestion.UseVisualStyleBackColor = false;
            switchquestion.Click += switchquestion_Click;
            // 
            // fiftyfifty
            // 
            fiftyfifty.BackColor = Color.FromArgb(20, 40, 80);
            fiftyfifty.Enabled = false;
            fiftyfifty.FlatAppearance.BorderColor = Color.DarkKhaki;
            fiftyfifty.FlatAppearance.BorderSize = 2;
            fiftyfifty.FlatStyle = FlatStyle.Flat;
            fiftyfifty.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            fiftyfifty.ForeColor = SystemColors.ButtonHighlight;
            fiftyfifty.Location = new Point(23, 230);
            fiftyfifty.Name = "fiftyfifty";
            fiftyfifty.Size = new Size(440, 54);
            fiftyfifty.TabIndex = 1;
            fiftyfifty.Text = "50:50";
            fiftyfifty.UseVisualStyleBackColor = false;
            fiftyfifty.Click += fiftyfifty_Click;
            // 
            // AnswerB
            // 
            AnswerB.BackColor = Color.FromArgb(20, 40, 80);
            AnswerB.Enabled = false;
            AnswerB.FlatAppearance.BorderColor = Color.DarkKhaki;
            AnswerB.FlatAppearance.BorderSize = 2;
            AnswerB.FlatStyle = FlatStyle.Flat;
            AnswerB.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            AnswerB.ForeColor = Color.Gold;
            AnswerB.Location = new Point(469, 290);
            AnswerB.Name = "AnswerB";
            AnswerB.Size = new Size(423, 121);
            AnswerB.TabIndex = 1;
            AnswerB.Tag = "";
            AnswerB.UseVisualStyleBackColor = false;
            AnswerB.Click += AnswerB_Click;
            // 
            // AnswerA
            // 
            AnswerA.BackColor = Color.FromArgb(20, 40, 80);
            AnswerA.Enabled = false;
            AnswerA.FlatAppearance.BorderColor = Color.DarkKhaki;
            AnswerA.FlatAppearance.BorderSize = 2;
            AnswerA.FlatStyle = FlatStyle.Flat;
            AnswerA.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            AnswerA.ForeColor = Color.Gold;
            AnswerA.Location = new Point(23, 290);
            AnswerA.Name = "AnswerA";
            AnswerA.Size = new Size(440, 121);
            AnswerA.TabIndex = 1;
            AnswerA.Tag = "";
            AnswerA.UseVisualStyleBackColor = false;
            AnswerA.Click += AnswerA_Click;
            // 
            // AnswerD
            // 
            AnswerD.BackColor = Color.FromArgb(20, 40, 80);
            AnswerD.Enabled = false;
            AnswerD.FlatAppearance.BorderColor = Color.DarkKhaki;
            AnswerD.FlatAppearance.BorderSize = 2;
            AnswerD.FlatStyle = FlatStyle.Flat;
            AnswerD.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            AnswerD.ForeColor = Color.Gold;
            AnswerD.Location = new Point(469, 417);
            AnswerD.Name = "AnswerD";
            AnswerD.Size = new Size(423, 121);
            AnswerD.TabIndex = 1;
            AnswerD.Tag = "";
            AnswerD.UseVisualStyleBackColor = false;
            AnswerD.Click += AnswerD_Click;
            // 
            // AnswerC
            // 
            AnswerC.BackColor = Color.FromArgb(20, 40, 80);
            AnswerC.Enabled = false;
            AnswerC.FlatAppearance.BorderColor = Color.DarkKhaki;
            AnswerC.FlatAppearance.BorderSize = 2;
            AnswerC.FlatStyle = FlatStyle.Flat;
            AnswerC.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            AnswerC.ForeColor = Color.Gold;
            AnswerC.Location = new Point(23, 417);
            AnswerC.Name = "AnswerC";
            AnswerC.Size = new Size(440, 121);
            AnswerC.TabIndex = 1;
            AnswerC.Tag = "";
            AnswerC.UseVisualStyleBackColor = false;
            AnswerC.Click += AnswerC_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Sylfaen", 13.2000008F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(583, 17);
            label1.Name = "label1";
            label1.Size = new Size(112, 29);
            label1.TabIndex = 3;
            label1.Text = "Current :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Sylfaen", 13.2000008F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Gold;
            label2.Location = new Point(264, 17);
            label2.Name = "label2";
            label2.Size = new Size(101, 29);
            label2.TabIndex = 3;
            label2.Text = "Money :";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(12, 18, 45);
            ClientSize = new Size(1122, 655);
            Controls.Add(AnswerC);
            Controls.Add(AnswerD);
            Controls.Add(label1);
            Controls.Add(labelcurrent);
            Controls.Add(AnswerA);
            Controls.Add(AnswerB);
            Controls.Add(LabelQuestion);
            Controls.Add(label2);
            Controls.Add(labelmoney);
            Controls.Add(labellevel);
            Controls.Add(withdrawbutton);
            Controls.Add(fiftyfifty);
            Controls.Add(switchquestion);
            Controls.Add(gamestart);
            Controls.Add(listlevel);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Who Wants to Be a Millionaire";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listlevel;
        private Button gamestart;
        private Button withdrawbutton;
        private Label labellevel;
        private Label labelmoney;
        private Label labelcurrent;
        private Label LabelQuestion;
        private Button switchquestion;
        private Button fiftyfifty;
        private Button AnswerB;
        private Button AnswerA;
        private Button AnswerD;
        private Button AnswerC;
        private Label label1;
        private Label label2;
    }
}
