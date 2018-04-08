using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AGL.Assessment.Domain.Model;

namespace AGL.Assessment.Web.Mvc.Models
{
    public class OwnerGenderWisePetsViewModel
    {
        private readonly SortOrder _sortOrder;
        private List<string> _pets;
        public OwnerGenderWisePetsViewModel(SortOrder sortOrder)
        {
            _sortOrder = sortOrder;
             Pets=new List<string>();

        }
        public OwnerGenderWisePetsViewModel()
        {
            _sortOrder = SortOrder.None;
            Pets=new List<string>();
        }
        public string Gender { get; set; }
        public List<string> Pets {
            get
            {
                if(_sortOrder==SortOrder.None) return _pets;

                return _sortOrder == SortOrder.Ascending ? _pets.OrderBy(k => k).ToList() : _pets.OrderByDescending(k => k).ToList();
            } 
            set { _pets = value; } }
      
    }
}