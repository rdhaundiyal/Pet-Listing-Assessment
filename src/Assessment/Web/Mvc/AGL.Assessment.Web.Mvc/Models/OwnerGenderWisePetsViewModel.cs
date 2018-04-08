using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AGL.Assessment.Domain.Model;

namespace AGL.Assessment.Web.Mvc.Models
{
    public class OwnerGenderWisePetsViewModel:List<string>
    {
        private readonly SortOrder _sortOrder;
       
        public OwnerGenderWisePetsViewModel(SortOrder sortOrder)
        {
            _sortOrder = sortOrder;
          

        }
        public OwnerGenderWisePetsViewModel()
        {
            _sortOrder = SortOrder.None;
          
        }
        public string Gender { get; set; }

        public List<string> Pets
        {
            get
            {
                if (_sortOrder == SortOrder.None) return this;

                return _sortOrder == SortOrder.Ascending
                    ? this.OrderBy(k => k).ToList()
                    : this.OrderByDescending(k => k).ToList();
            }
        }


    }
}