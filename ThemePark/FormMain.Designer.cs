namespace ThemePark
{
    partial class FormMain
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
            buttonBuyTicket = new Button();
            labelDiscriptionTotalCash = new Label();
            labelTotalCash = new Label();
            SuspendLayout();
            // 
            // buttonBuyTicket
            // 
            buttonBuyTicket.Location = new Point(28, 12);
            buttonBuyTicket.Name = "buttonBuyTicket";
            buttonBuyTicket.Size = new Size(354, 148);
            buttonBuyTicket.TabIndex = 0;
            buttonBuyTicket.Text = "Buy Ticket";
            buttonBuyTicket.UseVisualStyleBackColor = true;
            buttonBuyTicket.Click += buttonBuyTicket_Click;
            // 
            // labelDiscriptionTotalCash
            // 
            labelDiscriptionTotalCash.AutoSize = true;
            labelDiscriptionTotalCash.Location = new Point(-3, 211);
            labelDiscriptionTotalCash.Name = "labelDiscriptionTotalCash";
            labelDiscriptionTotalCash.Size = new Size(280, 41);
            labelDiscriptionTotalCash.TabIndex = 1;
            labelDiscriptionTotalCash.Text = "Total Cash On Hand";
            // 
            // labelTotalCash
            // 
            labelTotalCash.AutoSize = true;
            labelTotalCash.Location = new Point(348, 211);
            labelTotalCash.Name = "labelTotalCash";
            labelTotalCash.Size = new Size(34, 41);
            labelTotalCash.TabIndex = 2;
            labelTotalCash.Text = "0";
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.themeparkbackground;
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(1847, 923);
            Controls.Add(labelTotalCash);
            Controls.Add(labelDiscriptionTotalCash);
            Controls.Add(buttonBuyTicket);
            Name = "FormMain";
            Text = "Theme Park Manager";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonBuyTicket;
        private Label labelDiscriptionTotalCash;
        private Label labelTotalCash;
    }
}
