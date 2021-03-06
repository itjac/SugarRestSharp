// <auto-generated />
// This file was generated by a T4 template.
// Don't change it directly as your change would get overwritten.  Instead, make changes
// to the .tt file (i.e. the T4 template) and save it to regenerate this file.

// Make sure the compiler doesn't complain about missing Xml comments
#pragma warning disable 1591

namespace SugarRestSharp.Models
{
	using System;
	using Newtonsoft.Json;
	

    /// <summary>
    /// A class which represents the tasks table.
    /// </summary>
	[ModuleProperty(ModuleName = "Tasks", TableName="tasks")]
	public partial class Task : EntityBase
	{
		[JsonProperty(PropertyName = "id")]
		public virtual string Id { get; set; }

		[JsonProperty(PropertyName = "name")]
		public virtual string Name { get; set; }

		[JsonProperty(PropertyName = "date_entered")]
		public virtual DateTime? DateEntered { get; set; }

		[JsonProperty(PropertyName = "date_modified")]
		public virtual DateTime? DateModified { get; set; }

		[JsonProperty(PropertyName = "modified_user_id")]
		public virtual string ModifiedUserId { get; set; }

		[JsonProperty(PropertyName = "created_by")]
		public virtual string CreatedBy { get; set; }

		[JsonProperty(PropertyName = "description")]
		public virtual string Description { get; set; }

		[JsonProperty(PropertyName = "deleted")]
		public virtual sbyte? Deleted { get; set; }

		[JsonProperty(PropertyName = "assigned_user_id")]
		public virtual string AssignedUserId { get; set; }

		[JsonProperty(PropertyName = "status")]
		public virtual string Status { get; set; }

		[JsonProperty(PropertyName = "date_due_flag")]
		public virtual sbyte? DateDueFlag { get; set; }

		[JsonProperty(PropertyName = "date_due")]
		public virtual DateTime? DateDue { get; set; }

		[JsonProperty(PropertyName = "date_start_flag")]
		public virtual sbyte? DateStartFlag { get; set; }

		[JsonProperty(PropertyName = "date_start")]
		public virtual DateTime? DateStart { get; set; }

		[JsonProperty(PropertyName = "parent_type")]
		public virtual string ParentType { get; set; }

		[JsonProperty(PropertyName = "parent_id")]
		public virtual string ParentId { get; set; }

		[JsonProperty(PropertyName = "contact_id")]
		public virtual string ContactId { get; set; }

		[JsonProperty(PropertyName = "priority")]
		public virtual string Priority { get; set; }

	}
}