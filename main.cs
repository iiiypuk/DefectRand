using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace DefectRand
{
    partial class MainForm : Form
    {
        string[] defectStrings = {
            "Аккумуляторный отсек требует обслуживания.",
            "Не горит подсветка приборной панели."
        };
        public MainForm()
            {
             InitializeComponent();   
            }
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.randButton = new System.Windows.Forms.Button();
            this.textField = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();

            this.randButton.Location = new System.Drawing.Point(13, 231);
            this.randButton.Name = "randButton";
            this.randButton.Size = new System.Drawing.Size(263, 23);
            this.randButton.TabIndex = 0;
            this.randButton.Text = "Ещё";
            this.randButton.UseVisualStyleBackColor = true;
            randButton.Click += new EventHandler(getDefect);

            this.textField.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textField.Location = new System.Drawing.Point(13, 13);
            this.textField.Name = "textField";
            this.textField.Size = new System.Drawing.Size(263, 212);
            this.textField.TabIndex = 1;
            this.textField.Text = "Рандомайзер дефектов\nспециально для ВМО\n2017 by iiiypuk";

            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(288, 266);
            this.Controls.Add(this.textField);
            this.Controls.Add(this.randButton);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DefectRand - 1.0";
            this.ResumeLayout(false);
        }

        private void getDefect(object sender, EventArgs e)
        {
            // MessageBox.Show("Hello World");
            this.textField.Text = defectStrings[new Random().Next(0, defectStrings.Length)];
        }

        private System.Windows.Forms.Button randButton;
        private System.Windows.Forms.RichTextBox textField;
    }

    static class Program
    {
        [STAThread]
        public static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }
}
