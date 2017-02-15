
using MetroFramework;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Net;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows.Forms;
namespace PS3_Comment_Loader
{
    partial class mainFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainFrm));
            this.connectBtn = new MaterialSkin.Controls.MaterialFlatButton();
            this.ipBox = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.accLists = new System.Windows.Forms.ListBox();
            this.sendComment = new MaterialSkin.Controls.MaterialFlatButton();
            this.commentBox = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.picBox_false = new System.Windows.Forms.PictureBox();
            this.picBox_correct = new System.Windows.Forms.PictureBox();
            this.linkLabel = new MaterialSkin.Controls.MaterialLabel();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_false)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_correct)).BeginInit();
            this.SuspendLayout();
            // 
            // connectBtn
            // 
            this.connectBtn.AutoSize = true;
            this.connectBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.connectBtn.Depth = 0;
            this.connectBtn.Location = new System.Drawing.Point(24, 72);
            this.connectBtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.connectBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.connectBtn.Name = "connectBtn";
            this.connectBtn.Primary = false;
            this.connectBtn.Size = new System.Drawing.Size(75, 36);
            this.connectBtn.TabIndex = 0;
            this.connectBtn.Text = "Connect";
            this.connectBtn.UseVisualStyleBackColor = true;
            this.connectBtn.Click += connectEvent;
            // 
            // ipBox
            // 
            this.ipBox.Depth = 0;
            this.ipBox.Hint = "";
            this.ipBox.Location = new System.Drawing.Point(106, 85);
            this.ipBox.MouseState = MaterialSkin.MouseState.HOVER;
            this.ipBox.Name = "ipBox";
            this.ipBox.PasswordChar = '\0';
            this.ipBox.SelectedText = "";
            this.ipBox.SelectionLength = 0;
            this.ipBox.SelectionStart = 0;
            this.ipBox.Size = new System.Drawing.Size(229, 23);
            this.ipBox.TabIndex = 1;
            this.ipBox.UseSystemPasswordChar = false;
            this.ipBox.TextChanged += TextChangedEvent;
            // 
            // accLists
            // 
            this.accLists.FormattingEnabled = true;
            this.accLists.Location = new System.Drawing.Point(24, 145);
            this.accLists.Name = "accLists";
            this.accLists.Size = new System.Drawing.Size(339, 121);
            this.accLists.TabIndex = 2;
            this.accLists.SelectedIndexChanged += accListsSelectedIndexChanged;
            // 
            // sendComment
            // 
            this.sendComment.AutoSize = true;
            this.sendComment.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.sendComment.Depth = 0;
            this.sendComment.Location = new System.Drawing.Point(0, 0);
            this.sendComment.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.sendComment.MouseState = MaterialSkin.MouseState.HOVER;
            this.sendComment.Name = "sendComment";
            this.sendComment.Primary = false;
            this.sendComment.Size = new System.Drawing.Size(75, 23);
            this.sendComment.TabIndex = 0;
            // 
            // commentBox
            // 
            this.commentBox.Depth = 0;
            this.commentBox.Hint = "";
            this.commentBox.Location = new System.Drawing.Point(0, 0);
            this.commentBox.MouseState = MaterialSkin.MouseState.HOVER;
            this.commentBox.Name = "commentBox";
            this.commentBox.PasswordChar = '\0';
            this.commentBox.SelectedText = "";
            this.commentBox.SelectionLength = 0;
            this.commentBox.SelectionStart = 0;
            this.commentBox.Size = new System.Drawing.Size(0, 0);
            this.commentBox.TabIndex = 0;
            this.commentBox.UseSystemPasswordChar = false;
            // 
            // picBox_false
            // 
            this.picBox_false.BackColor = System.Drawing.Color.Transparent;
            this.picBox_false.Image = global::PS3_Comment_Loader.Properties.Resources.Entypo_2715_0__32;
            this.picBox_false.Location = new System.Drawing.Point(341, 85);
            this.picBox_false.Name = "picBox_false";
            this.picBox_false.Size = new System.Drawing.Size(36, 23);
            this.picBox_false.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBox_false.TabIndex = 7;
            this.picBox_false.TabStop = false;
            // 
            // picBox_correct
            // 
            this.picBox_correct.BackColor = System.Drawing.Color.Transparent;
            this.picBox_correct.Image = global::PS3_Comment_Loader.Properties.Resources.Entypo_2713_0__32;
            this.picBox_correct.Location = new System.Drawing.Point(341, 85);
            this.picBox_correct.Name = "picBox_correct";
            this.picBox_correct.Size = new System.Drawing.Size(36, 23);
            this.picBox_correct.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBox_correct.TabIndex = 6;
            this.picBox_correct.TabStop = false;
            // 
            // linkLabel
            // 
            this.linkLabel.AutoSize = true;
            this.linkLabel.Depth = 0;
            this.linkLabel.Font = new System.Drawing.Font("Roboto", 11F);
            this.linkLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.linkLabel.Location = new System.Drawing.Point(302, 332);
            this.linkLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.linkLabel.Name = "linkLabel";
            this.linkLabel.Size = new System.Drawing.Size(82, 19);
            this.linkLabel.TabIndex = 8;
            this.linkLabel.Text = "By BISOON";
            this.linkLabel.Click += linkLabelEvent;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 126);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "PS3 Users";
            // 
            // mainFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(389, 354);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.linkLabel);
            this.Controls.Add(this.picBox_false);
            this.Controls.Add(this.picBox_correct);
            this.Controls.Add(this.accLists);
            this.Controls.Add(this.ipBox);
            this.Controls.Add(this.connectBtn);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "mainFrm";
            this.Opacity = 0.95D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Comment Uploader";
            ((System.ComponentModel.ISupportInitialize)(this.picBox_false)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_correct)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        void frmClosing(object sender, FormClosingEventArgs e)
        {
            File.WriteAllText(Path.GetTempPath() + localIp, ipBox.Text);
        }

        void linkLabelEvent(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.youtube.com/c/bisoon");
        }

        void accListsSelectedIndexChanged(object sender, EventArgs e)
        {
            string userComment = ftp.ReadFile("/dev_hdd0/home/" + allusers[accLists.SelectedIndex] + "/friendim/mecomment.dat").Replace("\n", "").Trim();
            commentBox.Text = userComment;
        }

        void is_ip_format_Correct(bool bolean)
        {
            picBox_correct.Visible = bolean;
            picBox_false.Visible = !bolean;
        }
        int CountChar(string input, char chr)
        {
            return input.Split('.').Length - 1;
        }
        int CountChar(string input, string valueToBeCounted)
        {
            int count = Regex.Matches(input, "[" + valueToBeCounted + "]" + "{" + valueToBeCounted.Length + "}").Count;
            return count;
        }
        private void TextChangedEvent(object sender, System.EventArgs e)
        {
            if (Regex.IsMatch(ipBox.Text, ipFormat) && CountChar(ipBox.Text, ".") <= 3)
                is_ip_format_Correct(true);
            else
                is_ip_format_Correct(false);
        }
        FtpConnection ftp;
        List<String> allusers = new List<string>();
        void connectEvent(object sender, System.EventArgs e)
        {
            try
            {
                bool isFinished = false;
                if (new Regex(ipFormat).IsMatch(ipBox.Text))
                {
                   ftp = new FtpConnection(ipBox.Text);
                    NewThread(new System.Action(() =>
                    {
                        for (int i = defaultSize; i < maxSize; i++)
                        {
                            this.Size = new System.Drawing.Size(389, i);
                        }
                        ftp.SetCurrentDirectory("/dev_hdd0/home");

                        foreach (var item in ftp.GetDirectories("/dev_hdd0/home"))
                        {
                            if (item.Name.Length > 5)
                            {
                                accLists.Items.Add(ftp.ReadFile("/dev_hdd0/home/" + item.Name + "/localusername"));
                                allusers.Add(item.Name);
                            }
                        }
                        isFinished = true;
                    }));
                    while (!isFinished)
                        Application.DoEvents();
                    this.commentBox.Depth = 0;
                    this.commentBox.Hint = "";
                    this.commentBox.Location = new System.Drawing.Point(24, 267);
                    this.commentBox.MouseState = MaterialSkin.MouseState.HOVER;
                    this.commentBox.Name = "materialSingleLineTextField1";
                    this.commentBox.PasswordChar = '\0';
                    this.commentBox.SelectedText = "";
                    this.commentBox.SelectionLength = 0;
                    this.commentBox.SelectionStart = 0;
                    this.commentBox.Size = new System.Drawing.Size(339, 23);
                    this.commentBox.TabIndex = 3;
                    this.commentBox.UseSystemPasswordChar = false;
                    this.sendComment.AutoSize = true;
                    this.sendComment.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
                    this.sendComment.Depth = 0;
                    this.sendComment.Location = new System.Drawing.Point(134, 303);
                    this.sendComment.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
                    this.sendComment.MouseState = MaterialSkin.MouseState.HOVER;
                    this.sendComment.Name = "sendComment";
                    this.sendComment.Primary = false;
                    this.sendComment.Size = new System.Drawing.Size(118, 36);
                    this.sendComment.TabIndex = 4;
                    this.sendComment.Text = "Send Comment";
                    this.sendComment.UseVisualStyleBackColor = true;
                    this.sendComment.Click += sendCommentClick;
                    this.Controls.Add(this.commentBox);
                    this.Controls.Add(this.sendComment);
                }
                else
                {
                    MetroMessageBox.Show(this, "Error ip addrees not in correct format", "Success", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this,ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void sendCommentClick(object sender, EventArgs e)
        {
            try
            {
                string localPath = Path.GetTempPath() + "mecomment.dat";
                File.WriteAllText(localPath, "\n\n\n\n\n\n\n\n\n\n\n\n" + this.commentBox.Text);
                ftp.SetCurrentDirectory("/dev_hdd0/home/" + allusers[accLists.SelectedIndex] + "/friendim/");
                ftp.PutFile(localPath);
                MetroMessageBox.Show(this, "Successfully loaded", "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            catch { MetroMessageBox.Show(this, "Error couldn't find the folder", "Success", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        #endregion

        private MaterialSkin.Controls.MaterialFlatButton connectBtn;
        private MaterialSkin.Controls.MaterialSingleLineTextField ipBox;
        private MaterialSkin.Controls.MaterialFlatButton sendComment;
        private System.Windows.Forms.ListBox accLists;
        private MaterialSkin.Controls.MaterialSingleLineTextField commentBox;
        private System.Windows.Forms.PictureBox picBox_correct;
        private System.Windows.Forms.PictureBox picBox_false;
        private MaterialSkin.Controls.MaterialLabel linkLabel;
        private Label label1;
    }
}

