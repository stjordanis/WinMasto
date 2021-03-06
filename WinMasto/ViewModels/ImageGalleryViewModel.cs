﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mastonet.Entities;

namespace WinMasto.ViewModels
{
    public class ImageGalleryViewModel : StatusBaseViewModel
    {
        private Status _status;
        public Status Status { get { return _status; } set { Set(ref _status, value); } }

        public async void SetStatus(Status status, Attachment attachment)
        {
            await LoginUser();
            Status = status;
        }
    }
}
