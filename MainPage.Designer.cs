namespace MEMBERS_MANAGER
{
    partial class MainPage
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainPage));
            this.lblNewMember = new System.Windows.Forms.Label();
            this.bttnNewMember = new System.Windows.Forms.Button();
            this.lstVwMain = new System.Windows.Forms.ListView();
            this.cHName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cHSurname = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cHRanking = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cHHeight = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cHSex = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cHAge = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lblEditMember = new System.Windows.Forms.Label();
            this.lblDelete = new System.Windows.Forms.Label();
            this.lblMemberPage = new System.Windows.Forms.Label();
            this.bttnMemberPage = new System.Windows.Forms.Button();
            this.bttnDelete = new System.Windows.Forms.Button();
            this.bttnEditMember = new System.Windows.Forms.Button();
            this.bttnUpdateRanking = new System.Windows.Forms.Button();
            this.lblUpdateRanking = new System.Windows.Forms.Label();
            this.grpBoxMemberList = new System.Windows.Forms.GroupBox();
            this.grpBoxRankingChart = new System.Windows.Forms.GroupBox();
            this.chrtRanking = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.grpBoxMemberList.SuspendLayout();
            this.grpBoxRankingChart.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chrtRanking)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNewMember
            // 
            this.lblNewMember.AutoSize = true;
            this.lblNewMember.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNewMember.Location = new System.Drawing.Point(114, 9);
            this.lblNewMember.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNewMember.Name = "lblNewMember";
            this.lblNewMember.Size = new System.Drawing.Size(95, 16);
            this.lblNewMember.TabIndex = 0;
            this.lblNewMember.Text = "Nuovo socio";
            // 
            // bttnNewMember
            // 
            this.bttnNewMember.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnNewMember.Location = new System.Drawing.Point(117, 27);
            this.bttnNewMember.Margin = new System.Windows.Forms.Padding(2);
            this.bttnNewMember.Name = "bttnNewMember";
            this.bttnNewMember.Size = new System.Drawing.Size(92, 50);
            this.bttnNewMember.TabIndex = 1;
            this.bttnNewMember.Text = "➕";
            this.bttnNewMember.UseVisualStyleBackColor = true;
            this.bttnNewMember.Click += new System.EventHandler(this.bttnNewMember_Click);
            // 
            // lstVwMain
            // 
            this.lstVwMain.AccessibleDescription = "";
            this.lstVwMain.AccessibleName = "";
            this.lstVwMain.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.lstVwMain.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.cHName,
            this.cHSurname,
            this.cHRanking,
            this.cHHeight,
            this.cHSex,
            this.cHAge});
            this.lstVwMain.Cursor = System.Windows.Forms.Cursors.Default;
            this.lstVwMain.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstVwMain.FullRowSelect = true;
            this.lstVwMain.GridLines = true;
            this.lstVwMain.HideSelection = false;
            this.lstVwMain.Location = new System.Drawing.Point(5, 17);
            this.lstVwMain.Margin = new System.Windows.Forms.Padding(2);
            this.lstVwMain.Name = "lstVwMain";
            this.lstVwMain.Size = new System.Drawing.Size(331, 238);
            this.lstVwMain.TabIndex = 4;
            this.lstVwMain.UseCompatibleStateImageBehavior = false;
            this.lstVwMain.View = System.Windows.Forms.View.Details;
            this.lstVwMain.ItemActivate += new System.EventHandler(this.lstVwMain_ItemActivate);
            this.lstVwMain.SelectedIndexChanged += new System.EventHandler(this.lstVwMain_SelectedIndexChanged);
            // 
            // cHName
            // 
            this.cHName.Text = "Nome";
            this.cHName.Width = 65;
            // 
            // cHSurname
            // 
            this.cHSurname.Text = "Cognome";
            this.cHSurname.Width = 83;
            // 
            // cHRanking
            // 
            this.cHRanking.Text = "Classifica";
            this.cHRanking.Width = 71;
            // 
            // cHHeight
            // 
            this.cHHeight.Text = "Altezza";
            this.cHHeight.Width = 62;
            // 
            // cHSex
            // 
            this.cHSex.Text = "Sesso";
            this.cHSex.Width = 58;
            // 
            // cHAge
            // 
            this.cHAge.Text = "Età";
            this.cHAge.Width = 51;
            // 
            // lblEditMember
            // 
            this.lblEditMember.AutoSize = true;
            this.lblEditMember.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEditMember.Location = new System.Drawing.Point(480, 9);
            this.lblEditMember.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEditMember.Name = "lblEditMember";
            this.lblEditMember.Size = new System.Drawing.Size(109, 16);
            this.lblEditMember.TabIndex = 6;
            this.lblEditMember.Text = "Modifica socio";
            // 
            // lblDelete
            // 
            this.lblDelete.AutoSize = true;
            this.lblDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDelete.Location = new System.Drawing.Point(593, 9);
            this.lblDelete.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDelete.Name = "lblDelete";
            this.lblDelete.Size = new System.Drawing.Size(101, 16);
            this.lblDelete.TabIndex = 7;
            this.lblDelete.Text = "Elimina socio";
            // 
            // lblMemberPage
            // 
            this.lblMemberPage.AutoSize = true;
            this.lblMemberPage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMemberPage.Location = new System.Drawing.Point(8, 9);
            this.lblMemberPage.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMemberPage.Name = "lblMemberPage";
            this.lblMemberPage.Size = new System.Drawing.Size(105, 16);
            this.lblMemberPage.TabIndex = 8;
            this.lblMemberPage.Text = "Scheda Socio";
            // 
            // bttnMemberPage
            // 
            this.bttnMemberPage.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnMemberPage.Location = new System.Drawing.Point(11, 27);
            this.bttnMemberPage.Margin = new System.Windows.Forms.Padding(2);
            this.bttnMemberPage.Name = "bttnMemberPage";
            this.bttnMemberPage.Size = new System.Drawing.Size(102, 50);
            this.bttnMemberPage.TabIndex = 9;
            this.bttnMemberPage.Text = "🎾";
            this.bttnMemberPage.UseVisualStyleBackColor = true;
            this.bttnMemberPage.Click += new System.EventHandler(this.bttnMemberPage_Click);
            // 
            // bttnDelete
            // 
            this.bttnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnDelete.Location = new System.Drawing.Point(596, 27);
            this.bttnDelete.Margin = new System.Windows.Forms.Padding(2);
            this.bttnDelete.Name = "bttnDelete";
            this.bttnDelete.Size = new System.Drawing.Size(98, 50);
            this.bttnDelete.TabIndex = 10;
            this.bttnDelete.Text = "🗑️";
            this.bttnDelete.UseVisualStyleBackColor = true;
            this.bttnDelete.Click += new System.EventHandler(this.bttnDelete_Click);
            // 
            // bttnEditMember
            // 
            this.bttnEditMember.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnEditMember.Location = new System.Drawing.Point(483, 27);
            this.bttnEditMember.Margin = new System.Windows.Forms.Padding(2);
            this.bttnEditMember.Name = "bttnEditMember";
            this.bttnEditMember.Size = new System.Drawing.Size(106, 50);
            this.bttnEditMember.TabIndex = 11;
            this.bttnEditMember.Text = "✏️";
            this.bttnEditMember.UseVisualStyleBackColor = true;
            this.bttnEditMember.Click += new System.EventHandler(this.bttnEditMember_Click);
            // 
            // bttnUpdateRanking
            // 
            this.bttnUpdateRanking.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnUpdateRanking.Location = new System.Drawing.Point(213, 27);
            this.bttnUpdateRanking.Margin = new System.Windows.Forms.Padding(2);
            this.bttnUpdateRanking.Name = "bttnUpdateRanking";
            this.bttnUpdateRanking.Size = new System.Drawing.Size(120, 50);
            this.bttnUpdateRanking.TabIndex = 12;
            this.bttnUpdateRanking.Text = "🏆";
            this.bttnUpdateRanking.UseVisualStyleBackColor = true;
            this.bttnUpdateRanking.Click += new System.EventHandler(this.bttnUpdateRanking_Click);
            // 
            // lblUpdateRanking
            // 
            this.lblUpdateRanking.AutoSize = true;
            this.lblUpdateRanking.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUpdateRanking.Location = new System.Drawing.Point(210, 9);
            this.lblUpdateRanking.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUpdateRanking.Name = "lblUpdateRanking";
            this.lblUpdateRanking.Size = new System.Drawing.Size(123, 16);
            this.lblUpdateRanking.TabIndex = 13;
            this.lblUpdateRanking.Text = "Nuova classifica";
            // 
            // grpBoxMemberList
            // 
            this.grpBoxMemberList.Controls.Add(this.lstVwMain);
            this.grpBoxMemberList.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpBoxMemberList.Location = new System.Drawing.Point(11, 94);
            this.grpBoxMemberList.Margin = new System.Windows.Forms.Padding(2);
            this.grpBoxMemberList.Name = "grpBoxMemberList";
            this.grpBoxMemberList.Padding = new System.Windows.Forms.Padding(2);
            this.grpBoxMemberList.Size = new System.Drawing.Size(341, 262);
            this.grpBoxMemberList.TabIndex = 23;
            this.grpBoxMemberList.TabStop = false;
            this.grpBoxMemberList.Text = "Lista Soci";
            // 
            // grpBoxRankingChart
            // 
            this.grpBoxRankingChart.Controls.Add(this.chrtRanking);
            this.grpBoxRankingChart.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpBoxRankingChart.Location = new System.Drawing.Point(358, 94);
            this.grpBoxRankingChart.Margin = new System.Windows.Forms.Padding(2);
            this.grpBoxRankingChart.Name = "grpBoxRankingChart";
            this.grpBoxRankingChart.Padding = new System.Windows.Forms.Padding(2);
            this.grpBoxRankingChart.Size = new System.Drawing.Size(331, 262);
            this.grpBoxRankingChart.TabIndex = 24;
            this.grpBoxRankingChart.TabStop = false;
            this.grpBoxRankingChart.Text = "Statistiche socio";
            // 
            // chrtRanking
            // 
            this.chrtRanking.BackImageTransparentColor = System.Drawing.Color.White;
            chartArea1.AlignmentOrientation = System.Windows.Forms.DataVisualization.Charting.AreaAlignmentOrientations.Horizontal;
            chartArea1.AxisY.IsReversed = true;
            chartArea1.Name = "ChartArea1";
            this.chrtRanking.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chrtRanking.Legends.Add(legend1);
            this.chrtRanking.Location = new System.Drawing.Point(5, 18);
            this.chrtRanking.Margin = new System.Windows.Forms.Padding(2);
            this.chrtRanking.Name = "chrtRanking";
            this.chrtRanking.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Bright;
            series1.BorderColor = System.Drawing.Color.White;
            series1.BorderWidth = 3;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.IsXValueIndexed = true;
            series1.Legend = "Legend1";
            series1.Name = "Posizione";
            series1.XAxisType = System.Windows.Forms.DataVisualization.Charting.AxisType.Secondary;
            series1.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.DateTime;
            series1.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.UInt32;
            this.chrtRanking.Series.Add(series1);
            this.chrtRanking.Size = new System.Drawing.Size(321, 237);
            this.chrtRanking.TabIndex = 0;
            this.chrtRanking.Text = "chart1";
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGreen;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(700, 366);
            this.Controls.Add(this.grpBoxRankingChart);
            this.Controls.Add(this.grpBoxMemberList);
            this.Controls.Add(this.lblUpdateRanking);
            this.Controls.Add(this.bttnUpdateRanking);
            this.Controls.Add(this.bttnEditMember);
            this.Controls.Add(this.bttnDelete);
            this.Controls.Add(this.bttnMemberPage);
            this.Controls.Add(this.lblMemberPage);
            this.Controls.Add(this.lblDelete);
            this.Controls.Add(this.lblEditMember);
            this.Controls.Add(this.bttnNewMember);
            this.Controls.Add(this.lblNewMember);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MainPage";
            this.Text = "GESTORE SOCI";
            this.grpBoxMemberList.ResumeLayout(false);
            this.grpBoxRankingChart.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chrtRanking)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNewMember;
        private System.Windows.Forms.Button bttnNewMember;
        private System.Windows.Forms.ListView lstVwMain;
        private System.Windows.Forms.Label lblEditMember;
        private System.Windows.Forms.Label lblDelete;
        private System.Windows.Forms.Label lblMemberPage;
        private System.Windows.Forms.Button bttnMemberPage;
        private System.Windows.Forms.Button bttnDelete;
        private System.Windows.Forms.Button bttnEditMember;
        private System.Windows.Forms.Button bttnUpdateRanking;
        private System.Windows.Forms.Label lblUpdateRanking;
        private System.Windows.Forms.ColumnHeader cHName;
        private System.Windows.Forms.ColumnHeader cHSurname;
        private System.Windows.Forms.ColumnHeader cHRanking;
        private System.Windows.Forms.ColumnHeader cHHeight;
        private System.Windows.Forms.ColumnHeader cHSex;
        private System.Windows.Forms.ColumnHeader cHAge;
        private System.Windows.Forms.GroupBox grpBoxMemberList;
        private System.Windows.Forms.GroupBox grpBoxRankingChart;
        private System.Windows.Forms.DataVisualization.Charting.Chart chrtRanking;
    }
}

