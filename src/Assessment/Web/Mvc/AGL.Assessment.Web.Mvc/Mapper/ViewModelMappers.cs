using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AGL.Assessment.Domain.Dto;
using AGL.Assessment.Domain.Model;
using AGL.Assessment.Web.Mvc.Models;

namespace AGL.Assessment.Web.Mvc.Mapper
{
    public static class ViewModelMappers
    {
        public static IList<OwnerGenderWisePetsViewModel> ToOwnerGenderWisePetsViewModel(this IList<Person> personList, string petType ,SortOrder sortOrder=SortOrder.None)
        {

            var ownerGenderWiseCatList = personList.GroupBy(k => k.gender);


            var result = new List<OwnerGenderWisePetsViewModel>();
            foreach (var gender in ownerGenderWiseCatList)
            {
                var genderView = new OwnerGenderWisePetsViewModel(sortOrder) { Gender = gender.Key };

                foreach (var pet in gender.SelectMany(person => person.pets.Where(pet => pet.type.Equals(petType, StringComparison.InvariantCultureIgnoreCase))))
                {
                    genderView.Add(pet.name);
                }
                result.Add(genderView);

            }
            return result;
        }
    }
}