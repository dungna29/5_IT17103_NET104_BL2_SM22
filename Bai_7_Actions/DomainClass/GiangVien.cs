using System.Collections.Generic;

namespace Bai_7_Actions.DomainClass
{
    public class GiangVien
    {
        public string MaGV { get; set; }
        public string Ten { get; set; }
        public string Email { get; set; }
        public string Image { get; set; }

        public static List<GiangVien> GetAll()
        {
            return new List<GiangVien>()
            {
                new GiangVien() {MaGV = "dungna29",Email = "dungna1@fpt.edu.vn",Image = "URL"},
                new GiangVien() {MaGV = "dungna30",Email = "dungna2@fpt.edu.vn",Image = "URL"},
                new GiangVien() {MaGV = "dungna31",Email = "dungna3@fpt.edu.vn",Image = "URL"},
                new GiangVien() {MaGV = "dungna32",Email = "dungna4@fpt.edu.vn",Image = "URL"},
            };
        }

        public List<GiangVien> GetAll1()
        {
            return new List<GiangVien>()
            {
                new GiangVien() {MaGV = "dungna29",Email = "dungna1@fpt.edu.vn",Image = "URL"},
                new GiangVien() {MaGV = "dungna30",Email = "dungna2@fpt.edu.vn",Image = "URL"},
                new GiangVien() {MaGV = "dungna31",Email = "dungna3@fpt.edu.vn",Image = "URL"},
                new GiangVien() {MaGV = "dungna32",Email = "dungna4@fpt.edu.vn",Image = "URL"},
            };
        }
    }
}