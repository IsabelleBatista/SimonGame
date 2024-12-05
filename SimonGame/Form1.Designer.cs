namespace SimonGame
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
            components = new System.ComponentModel.Container();
            Title = new Label();
            Instruction = new Label();
            start = new Button();
            GameTimer = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // Title
            // 
            Title.AutoSize = true;
            Title.Font = new Font("Roboto Medium", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Title.ForeColor = SystemColors.Control;
            Title.Location = new Point(116, 20);
            Title.Name = "Title";
            Title.Size = new Size(292, 38);
            Title.TabIndex = 0;
            Title.Text = "Simon Says Game";
            Title.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Instruction
            // 
            Instruction.AutoSize = true;
            Instruction.Font = new Font("Roboto Light", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Instruction.ForeColor = SystemColors.Control;
            Instruction.Location = new Point(123, 399);
            Instruction.Name = "Instruction";
            Instruction.Size = new Size(285, 19);
            Instruction.TabIndex = 1;
            Instruction.Text = "Click on 3 blocks in the same sequence";
            // 
            // start
            // 
            start.BackColor = Color.DarkSeaGreen;
            start.Cursor = Cursors.Hand;
            start.FlatAppearance.BorderColor = SystemColors.ControlDarkDark;
            start.FlatStyle = FlatStyle.Flat;
            start.Font = new Font("Roboto Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            start.ForeColor = Color.Transparent;
            start.Location = new Point(196, 430);
            start.Name = "start";
            start.Size = new Size(105, 36);
            start.TabIndex = 2;
            start.Text = "Start";
            start.UseVisualStyleBackColor = false;
            start.Click += BtnClickEvent;
            // 
            // GameTimer
            // 
            GameTimer.Interval = 20;
            GameTimer.Tick += this.GameTimerEvent;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSlateGray;
            ClientSize = new Size(541, 484);
            Controls.Add(start);
            Controls.Add(Instruction);
            Controls.Add(Title);
            Name = "Form1";
            Text = "Simon Says";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Title;
        private Label Instruction;
        private Button start;
        private System.Windows.Forms.Timer GameTimer;
    }
}
