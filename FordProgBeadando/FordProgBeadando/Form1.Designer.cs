﻿namespace FordProgBeadando
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.top_panel = new System.Windows.Forms.Panel();
            this.bt_StepAnalyze = new System.Windows.Forms.Button();
            this.bt_Analyze = new System.Windows.Forms.Button();
            this.bt_openCsv = new System.Windows.Forms.Button();
            this.bt_acceptInput = new System.Windows.Forms.Button();
            this.tb_input = new System.Windows.Forms.TextBox();
            this.lbl_output = new System.Windows.Forms.Label();
            this.main_panel = new System.Windows.Forms.Panel();
            this.mid_panel = new System.Windows.Forms.Panel();
            this.lb_steps = new System.Windows.Forms.ListBox();
            this.dgv_ruleTable = new System.Windows.Forms.DataGridView();
            this.openCsvFile = new System.Windows.Forms.OpenFileDialog();
            this.top_panel.SuspendLayout();
            this.main_panel.SuspendLayout();
            this.mid_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ruleTable)).BeginInit();
            this.SuspendLayout();
            // 
            // top_panel
            // 
            this.top_panel.Controls.Add(this.bt_StepAnalyze);
            this.top_panel.Controls.Add(this.bt_Analyze);
            this.top_panel.Controls.Add(this.bt_openCsv);
            this.top_panel.Controls.Add(this.bt_acceptInput);
            this.top_panel.Controls.Add(this.tb_input);
            this.top_panel.Controls.Add(this.lbl_output);
            this.top_panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.top_panel.Location = new System.Drawing.Point(0, 0);
            this.top_panel.Name = "top_panel";
            this.top_panel.Size = new System.Drawing.Size(1264, 98);
            this.top_panel.TabIndex = 1;
            // 
            // bt_StepAnalyze
            // 
            this.bt_StepAnalyze.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bt_StepAnalyze.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bt_StepAnalyze.Location = new System.Drawing.Point(854, 12);
            this.bt_StepAnalyze.Name = "bt_StepAnalyze";
            this.bt_StepAnalyze.Size = new System.Drawing.Size(113, 68);
            this.bt_StepAnalyze.TabIndex = 7;
            this.bt_StepAnalyze.Text = "Léptet";
            this.bt_StepAnalyze.UseVisualStyleBackColor = true;
            this.bt_StepAnalyze.Click += new System.EventHandler(this.bt_StepAnalyze_Click);
            // 
            // bt_Analyze
            // 
            this.bt_Analyze.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bt_Analyze.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bt_Analyze.Location = new System.Drawing.Point(1145, 12);
            this.bt_Analyze.Name = "bt_Analyze";
            this.bt_Analyze.Size = new System.Drawing.Size(107, 68);
            this.bt_Analyze.TabIndex = 5;
            this.bt_Analyze.Text = "Elemez";
            this.bt_Analyze.UseVisualStyleBackColor = true;
            this.bt_Analyze.Click += new System.EventHandler(this.Bt_Analyze_Click);
            // 
            // bt_openCsv
            // 
            this.bt_openCsv.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bt_openCsv.Location = new System.Drawing.Point(12, 12);
            this.bt_openCsv.Name = "bt_openCsv";
            this.bt_openCsv.Size = new System.Drawing.Size(130, 68);
            this.bt_openCsv.TabIndex = 4;
            this.bt_openCsv.Text = "Megnyit";
            this.bt_openCsv.UseVisualStyleBackColor = true;
            this.bt_openCsv.Click += new System.EventHandler(this.Bt_openCsv_Click);
            // 
            // bt_acceptInput
            // 
            this.bt_acceptInput.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bt_acceptInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bt_acceptInput.Location = new System.Drawing.Point(693, 12);
            this.bt_acceptInput.Name = "bt_acceptInput";
            this.bt_acceptInput.Size = new System.Drawing.Size(130, 68);
            this.bt_acceptInput.TabIndex = 1;
            this.bt_acceptInput.Text = "Bevitel";
            this.bt_acceptInput.UseVisualStyleBackColor = true;
            this.bt_acceptInput.Click += new System.EventHandler(this.Bt_acceptInput_Click);
            // 
            // tb_input
            // 
            this.tb_input.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_input.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tb_input.Location = new System.Drawing.Point(170, 12);
            this.tb_input.Name = "tb_input";
            this.tb_input.Size = new System.Drawing.Size(494, 29);
            this.tb_input.TabIndex = 2;
            // 
            // lbl_output
            // 
            this.lbl_output.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_output.AutoSize = true;
            this.lbl_output.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbl_output.Location = new System.Drawing.Point(165, 55);
            this.lbl_output.Name = "lbl_output";
            this.lbl_output.Size = new System.Drawing.Size(72, 25);
            this.lbl_output.TabIndex = 3;
            this.lbl_output.Text = "output";
            // 
            // main_panel
            // 
            this.main_panel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.main_panel.Controls.Add(this.mid_panel);
            this.main_panel.Controls.Add(this.top_panel);
            this.main_panel.Location = new System.Drawing.Point(0, 0);
            this.main_panel.Name = "main_panel";
            this.main_panel.Size = new System.Drawing.Size(1264, 729);
            this.main_panel.TabIndex = 4;
            // 
            // mid_panel
            // 
            this.mid_panel.Controls.Add(this.lb_steps);
            this.mid_panel.Controls.Add(this.dgv_ruleTable);
            this.mid_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mid_panel.Location = new System.Drawing.Point(0, 98);
            this.mid_panel.Name = "mid_panel";
            this.mid_panel.Size = new System.Drawing.Size(1264, 631);
            this.mid_panel.TabIndex = 2;
            // 
            // lb_steps
            // 
            this.lb_steps.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_steps.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lb_steps.FormattingEnabled = true;
            this.lb_steps.HorizontalScrollbar = true;
            this.lb_steps.ItemHeight = 24;
            this.lb_steps.Location = new System.Drawing.Point(854, 6);
            this.lb_steps.Name = "lb_steps";
            this.lb_steps.Size = new System.Drawing.Size(398, 604);
            this.lb_steps.TabIndex = 1;
            // 
            // dgv_ruleTable
            // 
            this.dgv_ruleTable.AllowUserToAddRows = false;
            this.dgv_ruleTable.AllowUserToDeleteRows = false;
            this.dgv_ruleTable.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_ruleTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_ruleTable.GridColor = System.Drawing.SystemColors.ActiveBorder;
            this.dgv_ruleTable.Location = new System.Drawing.Point(12, 6);
            this.dgv_ruleTable.MinimumSize = new System.Drawing.Size(555, 275);
            this.dgv_ruleTable.Name = "dgv_ruleTable";
            this.dgv_ruleTable.ReadOnly = true;
            this.dgv_ruleTable.Size = new System.Drawing.Size(811, 333);
            this.dgv_ruleTable.TabIndex = 0;
            // 
            // openCsvFile
            // 
            this.openCsvFile.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 729);
            this.Controls.Add(this.main_panel);
            this.MinimumSize = new System.Drawing.Size(1280, 768);
            this.Name = "Form1";
            this.Text = "Form1";
            this.top_panel.ResumeLayout(false);
            this.top_panel.PerformLayout();
            this.main_panel.ResumeLayout(false);
            this.mid_panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ruleTable)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel top_panel;
        private System.Windows.Forms.Button bt_acceptInput;
        private System.Windows.Forms.TextBox tb_input;
        private System.Windows.Forms.Label lbl_output;
        private System.Windows.Forms.Panel main_panel;
        private System.Windows.Forms.Panel mid_panel;
        private System.Windows.Forms.ListBox lb_steps;
        private System.Windows.Forms.DataGridView dgv_ruleTable;
        private System.Windows.Forms.Button bt_openCsv;
        private System.Windows.Forms.OpenFileDialog openCsvFile;
        private System.Windows.Forms.Button bt_Analyze;
        private System.Windows.Forms.Button bt_StepAnalyze;
    }
}

