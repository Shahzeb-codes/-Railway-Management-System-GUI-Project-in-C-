namespace railway_app
{
    partial class TrainMaster
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblFormTitle = new System.Windows.Forms.Label();
            this.gbTrainDetails = new System.Windows.Forms.GroupBox();
            this.Add_train_textbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gbTrainList = new System.Windows.Forms.GroupBox();
            this.dgvTrains = new System.Windows.Forms.DataGridView();
            this.Save_btn = new System.Windows.Forms.Button();
            this.Close_btn = new System.Windows.Forms.Button();
            this.panelHeader.SuspendLayout();
            this.gbTrainDetails.SuspendLayout();
            this.gbTrainList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTrains)).BeginInit();
            this.SuspendLayout();
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.Red;
            this.panelHeader.Controls.Add(this.lblTitle);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(684, 60);
            this.panelHeader.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(12, 17);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(261, 29);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Railway Management";
            // 
            // lblFormTitle
            // 
            this.lblFormTitle.AutoSize = true;
            this.lblFormTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFormTitle.ForeColor = System.Drawing.Color.Lime;
            this.lblFormTitle.Location = new System.Drawing.Point(12, 75);
            this.lblFormTitle.Name = "lblFormTitle";
            this.lblFormTitle.Size = new System.Drawing.Size(126, 24);
            this.lblFormTitle.TabIndex = 1;
            this.lblFormTitle.Text = "Train Master";
            // 
            // gbTrainDetails
            // 
            this.gbTrainDetails.Controls.Add(this.Add_train_textbox);
            this.gbTrainDetails.Controls.Add(this.label1);
            this.gbTrainDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbTrainDetails.Location = new System.Drawing.Point(16, 112);
            this.gbTrainDetails.Name = "gbTrainDetails";
            this.gbTrainDetails.Size = new System.Drawing.Size(656, 120);
            this.gbTrainDetails.TabIndex = 2;
            this.gbTrainDetails.TabStop = false;
            this.gbTrainDetails.Text = "Train Details";
            this.gbTrainDetails.Enter += new System.EventHandler(this.gbTrainDetails_Enter);
            // 
            // Add_train_textbox
            // 
            this.Add_train_textbox.Location = new System.Drawing.Point(114, 34);
            this.Add_train_textbox.Name = "Add_train_textbox";
            this.Add_train_textbox.Size = new System.Drawing.Size(386, 21);
            this.Add_train_textbox.TabIndex = 1;
            this.Add_train_textbox.TextChanged += new System.EventHandler(this.Add_train_textbox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Train Name:";
            // 
            // gbTrainList
            // 
            this.gbTrainList.Controls.Add(this.dgvTrains);
            this.gbTrainList.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbTrainList.Location = new System.Drawing.Point(16, 320);
            this.gbTrainList.Name = "gbTrainList";
            this.gbTrainList.Size = new System.Drawing.Size(656, 240);
            this.gbTrainList.TabIndex = 4;
            this.gbTrainList.TabStop = false;
            this.gbTrainList.Text = "Train List";
            // 
            // dgvTrains
            // 
            this.dgvTrains.AllowUserToAddRows = false;
            this.dgvTrains.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.dgvTrains.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvTrains.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTrains.BackgroundColor = System.Drawing.Color.White;
            this.dgvTrains.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvTrains.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTrains.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvTrains.Location = new System.Drawing.Point(3, 17);
            this.dgvTrains.Name = "dgvTrains";
            this.dgvTrains.ReadOnly = true;
            this.dgvTrains.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTrains.Size = new System.Drawing.Size(650, 220);
            this.dgvTrains.TabIndex = 0;
            this.dgvTrains.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTrains_CellContentClick);
            // 
            // Save_btn
            // 
            this.Save_btn.Location = new System.Drawing.Point(506, 269);
            this.Save_btn.Name = "Save_btn";
            this.Save_btn.Size = new System.Drawing.Size(135, 35);
            this.Save_btn.TabIndex = 5;
            this.Save_btn.Text = "Save";
            this.Save_btn.UseVisualStyleBackColor = true;
            this.Save_btn.Click += new System.EventHandler(this.Save_btn_Click);
            // 
            // Close_btn
            // 
            this.Close_btn.Location = new System.Drawing.Point(333, 269);
            this.Close_btn.Name = "Close_btn";
            this.Close_btn.Size = new System.Drawing.Size(135, 35);
            this.Close_btn.TabIndex = 6;
            this.Close_btn.Text = "Close";
            this.Close_btn.UseVisualStyleBackColor = true;
            this.Close_btn.Click += new System.EventHandler(this.Close_btn_Click);
            // 
            // TrainMaster
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(684, 572);
            this.Controls.Add(this.Close_btn);
            this.Controls.Add(this.Save_btn);
            this.Controls.Add(this.gbTrainList);
            this.Controls.Add(this.gbTrainDetails);
            this.Controls.Add(this.lblFormTitle);
            this.Controls.Add(this.panelHeader);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TrainMaster";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Train Master";
            this.Load += new System.EventHandler(this.TrainMaster_Load);
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.gbTrainDetails.ResumeLayout(false);
            this.gbTrainDetails.PerformLayout();
            this.gbTrainList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTrains)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblFormTitle;
        private System.Windows.Forms.GroupBox gbTrainDetails;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbTrainList;
        private System.Windows.Forms.DataGridView dgvTrains;
        private System.Windows.Forms.Button Save_btn;
        private System.Windows.Forms.TextBox Add_train_textbox;
        private System.Windows.Forms.Button Close_btn;
    }
}