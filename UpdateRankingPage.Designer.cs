namespace MEMBERS_MANAGER
{
    partial class UpdateRankingPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpdateRankingPage));
            this.txtRanking = new System.Windows.Forms.TextBox();
            this.lblUpdateRanking = new System.Windows.Forms.Label();
            this.lblData = new System.Windows.Forms.Label();
            this.dtpRankingData = new System.Windows.Forms.DateTimePicker();
            this.bttnOk = new System.Windows.Forms.Button();
            this.bttnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtRanking
            // 
            this.txtRanking.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRanking.Location = new System.Drawing.Point(252, 217);
            this.txtRanking.Margin = new System.Windows.Forms.Padding(2);
            this.txtRanking.Name = "txtRanking";
            this.txtRanking.Size = new System.Drawing.Size(107, 26);
            this.txtRanking.TabIndex = 1;
            this.txtRanking.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.HandleInput);
            // 
            // lblUpdateRanking
            // 
            this.lblUpdateRanking.AutoSize = true;
            this.lblUpdateRanking.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUpdateRanking.Location = new System.Drawing.Point(218, 191);
            this.lblUpdateRanking.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUpdateRanking.Name = "lblUpdateRanking";
            this.lblUpdateRanking.Size = new System.Drawing.Size(199, 24);
            this.lblUpdateRanking.TabIndex = 2;
            this.lblUpdateRanking.Text = "Inserisci la classifica";
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblData.Location = new System.Drawing.Point(238, 70);
            this.lblData.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(160, 24);
            this.lblData.TabIndex = 3;
            this.lblData.Text = "Inserisci la data ";
            // 
            // dtpRankingData
            // 
            this.dtpRankingData.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpRankingData.Location = new System.Drawing.Point(172, 96);
            this.dtpRankingData.Margin = new System.Windows.Forms.Padding(2);
            this.dtpRankingData.Name = "dtpRankingData";
            this.dtpRankingData.Size = new System.Drawing.Size(272, 26);
            this.dtpRankingData.TabIndex = 4;
            // 
            // bttnOk
            // 
            this.bttnOk.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnOk.Location = new System.Drawing.Point(382, 313);
            this.bttnOk.Margin = new System.Windows.Forms.Padding(2);
            this.bttnOk.Name = "bttnOk";
            this.bttnOk.Size = new System.Drawing.Size(98, 43);
            this.bttnOk.TabIndex = 5;
            this.bttnOk.Text = "OK";
            this.bttnOk.UseVisualStyleBackColor = true;
            this.bttnOk.Click += new System.EventHandler(this.bttnOk_Click);
            // 
            // bttnCancel
            // 
            this.bttnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnCancel.Location = new System.Drawing.Point(494, 313);
            this.bttnCancel.Margin = new System.Windows.Forms.Padding(2);
            this.bttnCancel.Name = "bttnCancel";
            this.bttnCancel.Size = new System.Drawing.Size(98, 43);
            this.bttnCancel.TabIndex = 6;
            this.bttnCancel.Text = "Annulla";
            this.bttnCancel.UseVisualStyleBackColor = true;
            this.bttnCancel.Click += new System.EventHandler(this.bttnCancel_Click);
            // 
            // UpdateRankingPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGreen;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.bttnCancel);
            this.Controls.Add(this.bttnOk);
            this.Controls.Add(this.dtpRankingData);
            this.Controls.Add(this.lblData);
            this.Controls.Add(this.lblUpdateRanking);
            this.Controls.Add(this.txtRanking);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "UpdateRankingPage";
            this.Text = "Aggiorna Classifica";
            this.Load += new System.EventHandler(this.UpdateRankingPage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtRanking;
        private System.Windows.Forms.Label lblUpdateRanking;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.DateTimePicker dtpRankingData;
        private System.Windows.Forms.Button bttnOk;
        private System.Windows.Forms.Button bttnCancel;
    }
}