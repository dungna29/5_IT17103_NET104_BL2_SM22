using System.Collections.Generic;
using Bai_7_Actions.Models;

namespace Bai_7_Actions.DomainClass
{
    public class SinhVien
    {
        public string MaSV { get; set; }
        public string Ten { get; set; }
        public string Email { get; set; }
        public string Image { get; set; }

        public static List<SinhVien> GetAll()
        {
            return new List<SinhVien>()
            {
                new SinhVien() {MaSV = "PH123",Email = "dungna1@fpt.edu.vn",Image = "URL"},
                new SinhVien() {MaSV = "PH124",Email = "dungna2@fpt.edu.vn",Image = "URL"},
                new SinhVien() {MaSV = "PH125",Email = "dungna3@fpt.edu.vn",Image = "URL"},
                new SinhVien() {MaSV = "PH126",Email = "dungna4@fpt.edu.vn",Image = "URL"},
            };
        }

        public List<SinhVien> GetAll1()
        {
            return new List<SinhVien>()
            {
                new SinhVien() {MaSV = "PH123",Email = "dungna1@fpt.edu.vn",Image = "URL"},
                new SinhVien() {MaSV = "PH124",Email = "dungna2@fpt.edu.vn",Image = "URL"},
                new SinhVien() {MaSV = "PH125",Email = "dungna3@fpt.edu.vn",Image = "URL"},
                new SinhVien() {MaSV = "PH126",Email = "dungna4@fpt.edu.vn",Image = "URL"},
            };
        }
    }
}