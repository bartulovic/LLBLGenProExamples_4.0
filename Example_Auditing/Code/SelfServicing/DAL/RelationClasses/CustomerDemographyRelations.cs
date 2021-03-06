﻿///////////////////////////////////////////////////////////////
// This is generated code. 
//////////////////////////////////////////////////////////////
// Code is generated using LLBLGen Pro version: 4.0
// Code is generated on: dinsdag 9 april 2013 13:26:45
// Code is generated using templates: SD.TemplateBindings.SharedTemplates
// Templates vendor: Solutions Design.
// Templates version: 
//////////////////////////////////////////////////////////////
using System;
using System.Collections;
using System.Collections.Generic;
using SD.LLBLGen.Pro.Examples.Auditing;
using SD.LLBLGen.Pro.Examples.Auditing.FactoryClasses;
using SD.LLBLGen.Pro.Examples.Auditing.HelperClasses;
using SD.LLBLGen.Pro.ORMSupportClasses;

namespace SD.LLBLGen.Pro.Examples.Auditing.RelationClasses
{
	/// <summary>Implements the relations factory for the entity: CustomerDemography. </summary>
	public partial class CustomerDemographyRelations
	{
		/// <summary>CTor</summary>
		public CustomerDemographyRelations()
		{
		}

		/// <summary>Gets all relations of the CustomerDemographyEntity as a list of IEntityRelation objects.</summary>
		/// <returns>a list of IEntityRelation objects</returns>
		public virtual List<IEntityRelation> GetAllRelations()
		{
			List<IEntityRelation> toReturn = new List<IEntityRelation>();
			toReturn.Add(this.CustomerCustomerDemoEntityUsingCustomerTypeId);
			return toReturn;
		}

		#region Class Property Declarations

		/// <summary>Returns a new IEntityRelation object, between CustomerDemographyEntity and CustomerCustomerDemoEntity over the 1:n relation they have, using the relation between the fields:
		/// CustomerDemography.CustomerTypeId - CustomerCustomerDemo.CustomerTypeId
		/// </summary>
		public virtual IEntityRelation CustomerCustomerDemoEntityUsingCustomerTypeId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany, "CustomerCustomerDemo" , true);
				relation.AddEntityFieldPair(CustomerDemographyFields.CustomerTypeId, CustomerCustomerDemoFields.CustomerTypeId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("CustomerDemographyEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("CustomerCustomerDemoEntity", false);
				return relation;
			}
		}


		/// <summary>stub, not used in this entity, only for TargetPerEntity entities.</summary>
		public virtual IEntityRelation GetSubTypeRelation(string subTypeEntityName) { return null; }
		/// <summary>stub, not used in this entity, only for TargetPerEntity entities.</summary>
		public virtual IEntityRelation GetSuperTypeRelation() { return null;}
		#endregion

		#region Included Code

		#endregion
	}
	
	/// <summary>Static class which is used for providing relationship instances which are re-used internally for syncing</summary>
	internal static class StaticCustomerDemographyRelations
	{
		internal static readonly IEntityRelation CustomerCustomerDemoEntityUsingCustomerTypeIdStatic = new CustomerDemographyRelations().CustomerCustomerDemoEntityUsingCustomerTypeId;

		/// <summary>CTor</summary>
		static StaticCustomerDemographyRelations()
		{
		}
	}
}
