#region Copyright Syncfusion Inc. 2001-2023.
// Copyright Syncfusion Inc. 2001-2023. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using SampleBrowser.Maui.Base;
using System.ComponentModel;

namespace SampleBrowser.Maui.PdfViewer.SfPdfViewer
{
    public class PdfData : INotifyPropertyChanged
    {
        private Stream? _documentStream;
        private int? _pageCount;
        private string? _fileName;

        public event PropertyChangedEventHandler? PropertyChanged;
        public Stream? DocumentStream
        {
            get => _documentStream;
            set
            {
                _documentStream = value;
                OnPropertyChanged("DocumentStream");
            }
        }

        public int? PageCount
        {
            get => _pageCount;
            set
            {
                _pageCount = value;
                OnPropertyChanged("PageCount");
            }
        }

        public string? FileName
        {
            get
            {
                return _fileName;
            }
            set
            {
                _fileName = value;
                string basePath = "SampleBrowser.Maui.Resources.Pdf.";
                if (BaseConfig.IsIndividualSB)
                    basePath = "SampleBrowser.Maui.PdfViewer.Samples.Pdf.";
                if (string.IsNullOrEmpty(value) == false)
                    DocumentStream = this.GetType().Assembly.GetManifestResourceStream(basePath + value);
            }
        }

        public void OnPropertyChanged(string name)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
    }
}