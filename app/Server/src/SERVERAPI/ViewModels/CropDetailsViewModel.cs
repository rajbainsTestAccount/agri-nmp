﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SERVERAPI.ViewModels
{
    public class CropDetailsViewModel
    {
        public int? id { get; set; }
        public string title { get; set; }
        public string btnText { get; set; }
        public string fieldName { get; set; }
        public bool showCrude { get; set; }
        public bool stdCrude { get; set; }
        [Required(ErrorMessage = "Required")]
        [Range(1, 9999, ErrorMessage = "Required")]
        public string selTypOption { get; set; }
        public List<Models.StaticData.SelectListItem> typOptions { get; set; }
        [Required(ErrorMessage = "Required")]
        [Range(1, 9999, ErrorMessage = "Required")]
        public string selCropOption { get; set; }
        public List<Models.StaticData.SelectListItem> cropOptions { get; set; }
        public string selPrevOption { get; set; }
        public List<Models.StaticData.SelectListItem> prevOptions { get; set; }
        public string yield { get; set; }
        public string yieldUnit { get; set; }
        public string crude { get; set; }
        public string buttonPressed { get; set; }
        public string reqN { get; set; }
        public string reqP2o5 { get; set; }
        public string reqK2o { get; set; }
        public string remN { get; set; }
        public string remP2o5 { get; set; }
        public string remK2o { get; set; }
        public bool manEntry { get; set; }
        public string cropDesc { get; set; }
        public string nCredit { get; set; }
        public string nCreditLabel { get; set; }
        public bool coverCrop { get; set; }
        public bool? coverCropHarvested { get; set; }
        public bool modNitrogen { get; set; }
        public bool stdN { get; set; }
        public string stdNAmt { get; set; }
        public bool stdYield { get; set; }
        public bool showHarvestUnitsDDL { get; set; }
        public List<Models.StaticData.SelectListItem> harvestUnitsOptions { get; set; }
        public string selHarvestUnits { get; set; }
        [Required(ErrorMessage = "Required")]
        public string yieldByHarvestUnit { get; set; }
    }
}