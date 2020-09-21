﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BookApp.Shared
{
    /// <summary>
    /// 기본 클래스: 공통 속성들을 모두 모아 놓은 모델 클래스
    /// </summary>
    public class BookBase
    {
        /// <summary>
        /// 책번호
        /// </summary>
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Display(Name ="번호")]
        public int Id { get; set; }

        /// <summary>
        /// 책 제목
        /// </summary>
        [MaxLength(255)]
        [Required(ErrorMessage ="책 제목을 입력하세요.")]
        [Display(Name ="책 제목")]
        [Column(TypeName ="NVarChar(255")]
        public string Title { get; set; }

        /// <summary>
        /// 책 설명
        /// </summary>
        [Display(Name = "책 설명")]
        public string Description { get; set; }
    }

    [Table("Books")]
    public class Book : BookBase
    {
        // 인스톨 패키지 필요
        //Empty
    }
}
