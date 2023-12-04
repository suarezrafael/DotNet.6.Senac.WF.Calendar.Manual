namespace Senac.WF.Calendar.Manual
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
            flowLayoutPanel1 = new FlowLayoutPanel();
            btnPrevMonth = new Button();
            btnNextMonth = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            panel1 = new Panel();
            label1 = new Label();
            flowLayoutPanel1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(btnPrevMonth);
            flowLayoutPanel1.Controls.Add(btnNextMonth);
            flowLayoutPanel1.Controls.Add(label1);
            flowLayoutPanel1.Location = new Point(3, 3);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(378, 50);
            flowLayoutPanel1.TabIndex = 0;
            // 
            // btnPrevMonth
            // 
            btnPrevMonth.Location = new Point(3, 3);
            btnPrevMonth.Name = "btnPrevMonth";
            btnPrevMonth.Size = new Size(94, 29);
            btnPrevMonth.TabIndex = 0;
            btnPrevMonth.Text = "<";
            btnPrevMonth.UseVisualStyleBackColor = true;
            btnPrevMonth.Click += btnPrevMonth_Click_1;
            // 
            // btnNextMonth
            // 
            btnNextMonth.Location = new Point(103, 3);
            btnNextMonth.Name = "btnNextMonth";
            btnNextMonth.Size = new Size(94, 29);
            btnNextMonth.TabIndex = 1;
            btnNextMonth.Text = ">";
            btnNextMonth.UseVisualStyleBackColor = true;
            btnNextMonth.Click += btnNextMonth_Click_1;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(flowLayoutPanel1, 0, 0);
            tableLayoutPanel1.Controls.Add(panel1, 0, 1);
            tableLayoutPanel1.Location = new Point(3, 3);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 640F));
            tableLayoutPanel1.Size = new Size(1447, 734);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // panel1
            // 
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(3, 97);
            panel1.Name = "panel1";
            panel1.Size = new Size(1441, 634);
            panel1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(203, 0);
            label1.Name = "label1";
            label1.Size = new Size(50, 20);
            label1.TabIndex = 2;
            label1.Text = "label1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1462, 749);
            Controls.Add(tableLayoutPanel1);
            Name = "Form1";
            Text = "Form1";
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanel1;
        private Button btnPrevMonth;
        private Button btnNextMonth;
        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel1;
        private Label label1;
    }
}
