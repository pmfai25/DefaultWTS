﻿using Windows.ApplicationModel.DataTransfer;

namespace DefaultWindowsTemplateStudioCSharp.Models
{
    public class DragDropData
    {
        public DataPackageOperation AcceptedOperation { get; set; }

        public DataPackageView DataView { get; set; }
    }
}
