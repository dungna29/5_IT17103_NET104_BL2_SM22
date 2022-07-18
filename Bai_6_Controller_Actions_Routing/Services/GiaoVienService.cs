using System.Collections.Generic;
using Bai_6_Controller_Actions_Routing.Models;

namespace Bai_6_Controller_Actions_Routing.Services
{
    public class GiaoVienService
    {
        public List<GiaoVien> _getLstGiaoViens;

        public GiaoVienService()
        {
            _getLstGiaoViens = new List<GiaoVien>()
            {
                new GiaoVien() {MaGV = "dungna29",Ten = "Dũng",Email = "Dungna29@fe.edu.vn",Image = "/images/img1.jpg"},
                new GiaoVien() {MaGV = "minhdq",Ten = "Minh",Email = "Minh@fe.edu.vn",Image = "/images/img1.jpg"},
                new GiaoVien() {MaGV = "thienth",Ten = "Thiện",Email = "thienth@fe.edu.vn",Image = "/images/img1.jpg"},
                new GiaoVien() {MaGV = "tiennh",Ten = "Tiến",Email = "tiennh@fe.edu.vn",Image = "/images/img1.jpg"},
                new GiaoVien() {MaGV = "datlt",Ten = "Đạt",Email = "datlt@fe.edu.vn",Image = "/images/img1.jpg"},
            };
        }
    }
}