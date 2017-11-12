using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class ChatLieu_DTO
    {
        string _maChatLieu;
        string _tenChatLieu;
        Boolean _trangThai;
       

        public string MaChatLieu
        {
            get
            {
                return _maChatLieu;
            }

            set
            {
                _maChatLieu = value;
            }
        }

        public string TenChatLieu
        {
            get
            {
                return _tenChatLieu;
            }

            set
            {
                _tenChatLieu = value;
            }
        }

        public bool TrangThai
        {
            get
            {
                return _trangThai;
            }

            set
            {
                _trangThai = value;
            }
        }
    }
}
