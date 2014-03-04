﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.17929
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MySql.Data.Entity.Tests.Properties {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class SQLSyntax {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal SQLSyntax() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("MySql.Data.Entity.Tests.Properties.SQLSyntax", typeof(SQLSyntax).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to SELECT
        ///`Extent1`.`Id`, 
        ///`Extent1`.`Name`, 
        ///`Extent1`.`Age`
        ///FROM `Authors` AS `Extent1`
        /// WHERE NOT EXISTS(SELECT
        ///1 AS `C1`
        ///FROM `Books` AS `Extent2`
        /// WHERE `Extent1`.`Id` = `Extent2`.`Author_id`).
        /// </summary>
        internal static string Any {
            get {
                return ResourceManager.GetString("Any", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to SELECT
        ///`GroupBy1`.`A1` AS `C1`
        ///FROM (SELECT
        ///AVG(`Extent1`.`MinAge`) AS `A1`
        ///FROM `Toys` AS `Extent1`) AS `GroupBy1`.
        /// </summary>
        internal static string AverageSimple {
            get {
                return ResourceManager.GetString("AverageSimple", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to SELECT
        ///1 AS `C1`, 
        ///`GroupBy1`.`A1` AS `C2`
        ///FROM (SELECT
        ///`Extent1`.`ShopId` AS `K1`, 
        ///AVG(`Extent1`.`Freight`) AS `A1`
        ///FROM `Orders` AS `Extent1`
        /// GROUP BY 
        ///`Extent1`.`ShopId`) AS `GroupBy1`.
        /// </summary>
        internal static string AverageWithGrouping {
            get {
                return ResourceManager.GetString("AverageWithGrouping", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to SELECT
        ///`GroupBy1`.`A1` AS `C1`
        ///FROM (SELECT
        ///AVG(`Extent1`.`Freight`) AS `A1`
        ///FROM `Orders` AS `Extent1`
        /// WHERE `Extent1`.`ShopId` = 3) AS `GroupBy1`.
        /// </summary>
        internal static string AverageWithPredicate {
            get {
                return ResourceManager.GetString("AverageWithPredicate", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to SELECT
        ///`GroupBy1`.`A1` AS `C1`
        ///FROM (SELECT
        ///COUNT(`Extent1`.`Id`) AS `A1`
        ///FROM `Toys` AS `Extent1`) AS `GroupBy1`.
        /// </summary>
        internal static string BigCountSimple {
            get {
                return ResourceManager.GetString("BigCountSimple", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to SELECT
        ///1 AS `C1`, 
        ///`GroupBy1`.`K1` AS `Name`, 
        ///`GroupBy1`.`A1` AS `C2`
        ///FROM (SELECT
        ///`Extent1`.`Name` AS `K1`, 
        ///`Extent1`.`DateBegan` AS `K2`, 
        ///`Extent1`.`NumEmployees` AS `K3`, 
        ///COUNT(1) AS `A1`
        ///FROM `Companies` AS `Extent1`
        /// GROUP BY 
        ///`Extent1`.`Name`, 
        ///`Extent1`.`DateBegan`, 
        ///`Extent1`.`NumEmployees`) AS `GroupBy1`.
        /// </summary>
        internal static string CanGroupByMultipleColumns {
            get {
                return ResourceManager.GetString("CanGroupByMultipleColumns", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to SELECT
        ///1 AS `C1`, 
        ///`GroupBy1`.`K1` AS `Name`, 
        ///`GroupBy1`.`A1` AS `C2`
        ///FROM (SELECT
        ///`Extent1`.`Name` AS `K1`, 
        ///COUNT(1) AS `A1`
        ///FROM `Companies` AS `Extent1`
        /// GROUP BY 
        ///`Extent1`.`Name`) AS `GroupBy1`.
        /// </summary>
        internal static string CanGroupBySingleColumn {
            get {
                return ResourceManager.GetString("CanGroupBySingleColumn", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to SELECT
        ///`Project2`.`C1`, 
        ///`Project2`.`Id`, 
        ///`Project2`.`LastName`, 
        ///`Project2`.`FirstName`, 
        ///`Project2`.`Age`, 
        ///`Project2`.`C2`
        ///FROM (SELECT
        ///`Extent1`.`Id`, 
        ///`Extent1`.`LastName`, 
        ///`Extent1`.`FirstName`, 
        ///`Extent1`.`Age`, 
        ///CASE WHEN (NOT ((`Project1`.`C1` = 1) AND (`Project1`.`C1` IS NOT NULL))) THEN (@gp1)  ELSE (@gp2) END AS `C1`, 
        ///CASE WHEN (NOT ((`Project1`.`C1` = 1) AND (`Project1`.`C1` IS NOT NULL))) THEN (NULL)  ELSE (`Project1`.`Salary`) END AS `C2`
        ///FROM `Employees` AS `Extent1` LEFT OU [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string ContainsTranslatedToLike {
            get {
                return ResourceManager.GetString("ContainsTranslatedToLike", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to SELECT
        ///`GroupBy1`.`A1` AS `C1`
        ///FROM (SELECT
        ///COUNT(`Extent1`.`Id`) AS `A1`
        ///FROM `Toys` AS `Extent1`) AS `GroupBy1`.
        /// </summary>
        internal static string CountSimple {
            get {
                return ResourceManager.GetString("CountSimple", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to SELECT
        ///`GroupBy1`.`A1` AS `C1`
        ///FROM (SELECT
        ///COUNT(`Extent1`.`Id`) AS `A1`
        ///FROM `Toys` AS `Extent1`
        /// WHERE `Extent1`.`MinAge` &gt; 3) AS `GroupBy1`.
        /// </summary>
        internal static string CountWithPredicate {
            get {
                return ResourceManager.GetString("CountWithPredicate", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to SELECT
        ///  `Project2`.`C1`, 
        ///  `Project2`.`Id`, 
        ///  `Project2`.`LastName`, 
        ///  `Project2`.`FirstName`, 
        ///  `Project2`.`Age`, 
        ///  `Project2`.`C2`
        ///  FROM (SELECT
        ///  `Extent1`.`Id`, 
        ///  `Extent1`.`LastName`, 
        ///  `Extent1`.`FirstName`, 
        ///  `Extent1`.`Age`, 
        ///  CASE WHEN (NOT ((`Project1`.`C1` = 1) AND (`Project1`.`C1` IS NOT NULL))) THEN (@gp1)  ELSE (@gp2) END AS `C1`, 
        ///  CASE WHEN (NOT ((`Project1`.`C1` = 1) AND (`Project1`.`C1` IS NOT NULL))) THEN (NULL)  ELSE (`Project1`.`Salary`) END AS `C2`
        ///  FROM `Emp [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string EndsWithTranslatedLikeApostrophes {
            get {
                return ResourceManager.GetString("EndsWithTranslatedLikeApostrophes", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to SELECT
        ///`Project2`.`C1`, 
        ///`Project2`.`Id`, 
        ///`Project2`.`LastName`, 
        ///`Project2`.`FirstName`, 
        ///`Project2`.`Age`, 
        ///`Project2`.`C2`
        ///FROM (SELECT
        ///`Extent1`.`Id`, 
        ///`Extent1`.`LastName`, 
        ///`Extent1`.`FirstName`, 
        ///`Extent1`.`Age`, 
        ///CASE WHEN (NOT ((`Project1`.`C1` = 1) AND (`Project1`.`C1` IS NOT NULL))) THEN (@gp1)  ELSE (@gp2) END AS `C1`, 
        ///CASE WHEN (NOT ((`Project1`.`C1` = 1) AND (`Project1`.`C1` IS NOT NULL))) THEN (NULL)  ELSE (`Project1`.`Salary`) END AS `C2`
        ///FROM `Employees` AS `Extent1` LEFT OU [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string EndsWithTranslatedToLike {
            get {
                return ResourceManager.GetString("EndsWithTranslatedToLike", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to SELECT
        ///`Extent1`.`Id`, 
        ///`Extent1`.`Name`, 
        ///`Extent1`.`DateBegan`, 
        ///`Extent1`.`NumEmployees`, 
        ///`Extent1`.`Address`, 
        ///`Extent1`.`City`, 
        ///`Extent1`.`State`, 
        ///`Extent1`.`ZipCode`
        ///FROM `Companies` AS `Extent1`
        /// WHERE EXISTS(SELECT
        ///1 AS `C1`
        ///FROM `Toys` AS `Extent2`
        /// WHERE (`Extent1`.`Id` = `Extent2`.`SupplierId`) AND (`Extent2`.`MinAge` &lt; 4)).
        /// </summary>
        internal static string Exists {
            get {
                return ResourceManager.GetString("Exists", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to SELECT
        ///`Project2`.`C1`, 
        ///`Project2`.`Id`, 
        ///`Project2`.`LastName`, 
        ///`Project2`.`FirstName`, 
        ///`Project2`.`Age`, 
        ///`Project2`.`C2`
        ///FROM (SELECT
        ///`Extent1`.`Id`, 
        ///`Extent1`.`LastName`, 
        ///`Extent1`.`FirstName`, 
        ///`Extent1`.`Age`, 
        ///CASE WHEN (NOT ((`Project1`.`C1` = 1) AND (`Project1`.`C1` IS NOT NULL))) THEN (@gp2)  ELSE (@gp3) END AS `C1`, 
        ///CASE WHEN (NOT ((`Project1`.`C1` = 1) AND (`Project1`.`C1` IS NOT NULL))) THEN (NULL)  ELSE (`Project1`.`Salary`) END AS `C2`
        ///FROM `Employees` AS `Extent1` LEFT OU [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string InExpressionComplex {
            get {
                return ResourceManager.GetString("InExpressionComplex", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to SELECT
        ///`Project2`.`C1`, 
        ///`Project2`.`Id`, 
        ///`Project2`.`LastName`, 
        ///`Project2`.`FirstName`, 
        ///`Project2`.`Age`, 
        ///`Project2`.`C2`
        ///FROM (SELECT
        ///`Extent1`.`Id`, 
        ///`Extent1`.`LastName`, 
        ///`Extent1`.`FirstName`, 
        ///`Extent1`.`Age`, 
        ///CASE WHEN (NOT ((`Project1`.`C1` = 1) AND (`Project1`.`C1` IS NOT NULL))) THEN (@gp1)  ELSE (@gp2) END AS `C1`, 
        ///CASE WHEN (NOT ((`Project1`.`C1` = 1) AND (`Project1`.`C1` IS NOT NULL))) THEN (NULL)  ELSE (`Project1`.`Salary`) END AS `C2`
        ///FROM `Employees` AS `Extent1` LEFT OU [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string InExpressionSimple {
            get {
                return ResourceManager.GetString("InExpressionSimple", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to SELECT
        ///`Project2`.`C1`, 
        ///`Project2`.`Id`, 
        ///`Project2`.`LastName`, 
        ///`Project2`.`FirstName`, 
        ///`Project2`.`Age`, 
        ///`Project2`.`C2`
        ///FROM (SELECT
        ///`Extent1`.`Id`, 
        ///`Extent1`.`LastName`, 
        ///`Extent1`.`FirstName`, 
        ///`Extent1`.`Age`, 
        ///CASE WHEN (NOT ((`Project1`.`C1` = 1) AND (`Project1`.`C1` IS NOT NULL))) THEN (@gp1)  ELSE (@gp2) END AS `C1`, 
        ///CASE WHEN (NOT ((`Project1`.`C1` = 1) AND (`Project1`.`C1` IS NOT NULL))) THEN (NULL)  ELSE (`Project1`.`Salary`) END AS `C2`
        ///FROM `Employees` AS `Extent1` LEFT OU [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string InExpressionSimpleEF6 {
            get {
                return ResourceManager.GetString("InExpressionSimpleEF6", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to SELECT
        ///`Project1`.`Id`, 
        ///`Project1`.`Name`, 
        ///`Project1`.`Pages`, 
        ///`Project1`.`Id1`, 
        ///`Project1`.`Name1`, 
        ///`Project1`.`Age`, 
        ///`Project1`.`Id2`, 
        ///`Project1`.`Name2`, 
        ///`Project1`.`C1`, 
        ///`Project1`.`Id3`, 
        ///`Project1`.`Name3`, 
        ///`Project1`.`Pages1`, 
        ///`Project1`.`Author_id`, 
        ///`Project1`.`Publisher_id`
        ///FROM (SELECT
        ///`Extent1`.`Id`, 
        ///`Extent1`.`Name`, 
        ///`Extent1`.`Pages`, 
        ///`Extent2`.`Id` AS `Id1`, 
        ///`Extent2`.`Name` AS `Name1`, 
        ///`Extent2`.`Age`, 
        ///`Extent3`.`id` AS `Id2`, 
        ///`Extent3`.`name` AS `Nam [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string JoinOfNestedUnionsWithLimit {
            get {
                return ResourceManager.GetString("JoinOfNestedUnionsWithLimit", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to SELECT
        ///`UnionAll1`.`Id` AS `C1`, 
        ///`UnionAll1`.`Name` AS `C2`, 
        ///`UnionAll1`.`MinAge` AS `C3`, 
        ///`UnionAll1`.`SupplierId` AS `C4`
        ///FROM (SELECT
        ///`Extent1`.`Id`, 
        ///`Extent1`.`Name`, 
        ///`Extent1`.`MinAge`, 
        ///`Extent1`.`SupplierId`
        ///FROM `Toys` AS `Extent1` UNION ALL (SELECT
        ///`Id`, 
        ///`Name`, 
        ///`MinAge`, 
        ///`SupplierId`
        ///FROM `Toys` LIMIT 0)) AS `UnionAll1`
        /// </summary>
        internal static string UnionWithLimit
        {
          get
          {
            return ResourceManager.GetString("UnionWithLimit", resourceCulture);
          }
        }

        /// <summary>
        ///   Looks up a localized string similar to SELECT ...
        /// </summary>
        internal static string UnionWithLimit2
        {
          get
          {
            return ResourceManager.GetString("UnionWithLimit2", resourceCulture);
          }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to SELECT
        ///`Extent1`.`Id`, 
        ///`Extent1`.`Name`, 
        ///`Join1`.`Id` AS `C1`, 
        ///`Join1`.`Name` AS `C2`, 
        ///`Join1`.`ID1` AS `C3`, 
        ///`Join1`.`NAME1` AS `C4`
        ///FROM `Companies` AS `Extent1` INNER JOIN (SELECT
        ///`UnionAll1`.`Id`, 
        ///`UnionAll1`.`Name`, 
        ///`UnionAll2`.`Id` AS `ID1`, 
        ///`UnionAll2`.`Name` AS `NAME1`
        ///FROM (SELECT
        ///`Extent2`.`Id`, 
        ///`Extent2`.`Name`
        ///FROM `Toys` AS `Extent2` UNION ALL SELECT
        ///`Extent3`.`Id`, 
        ///`Extent3`.`Name`
        ///FROM `Shops` AS `Extent3`) AS `UnionAll1` INNER JOIN (SELECT
        ///`Extent4`.`Id`, 
        ///`Extent4`.`Name`
        ///FROM `Au [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string JoinOfUnionsOnRightSideOfJoin {
            get {
                return ResourceManager.GetString("JoinOfUnionsOnRightSideOfJoin", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to SELECT
        ///`Extent1`.`Id`, 
        ///`Extent1`.`EmployeeID`, 
        ///`Extent1`.`LastName`, 
        ///`Extent1`.`FirstName`, 
        ///`Extent1`.`BirthTime`, 
        ///`Extent1`.`Weight`, 
        ///`Extent1`.`LastModified`
        ///FROM `EmployeeChildren` AS `Extent1` INNER JOIN (SELECT
        ///`Extent2`.`Id`, 
        ///`Extent2`.`LastName`, 
        ///`Extent2`.`FirstName`, 
        ///`Extent2`.`Age`, 
        ///`Extent3`.`EmployeeId`, 
        ///`Extent3`.`Salary`
        ///FROM `Employees` AS `Extent2` LEFT OUTER JOIN `SalariedEmployees` AS `Extent3` ON `Extent2`.`Id` = `Extent3`.`EmployeeId`) AS `Join1` ON `Extent1`.`E [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string JoinOnRightSideAsDerivedTable {
            get {
                return ResourceManager.GetString("JoinOnRightSideAsDerivedTable", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to SELECT
        ///`Extent1`.`Id`, 
        ///`Extent1`.`Name`, 
        ///`Join1`.`Id` AS `Id1`, 
        ///`Join1`.`Name` AS `Name1`, 
        ///`Join1`.`Id1` AS `Id2`, 
        ///`Join1`.`Name1` AS `Name2`
        ///FROM `Companies` AS `Extent1` INNER JOIN (SELECT
        ///`Extent2`.`Id`, 
        ///`Extent2`.`Name`, 
        ///`Extent2`.`Age`, 
        ///`Extent3`.`Id` AS `Id1`, 
        ///`Extent3`.`Name` AS `Name1`, 
        ///`Extent3`.`Pages`, 
        ///`Extent3`.`Author_id`, 
        ///`Extent3`.`Publisher_id`
        ///FROM `Authors` AS `Extent2` INNER JOIN `Books` AS `Extent3` ON `Extent2`.`Id` = `Extent3`.`Id`) AS `Join1` ON `Extent1`.` [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string JoinOnRightSideNameClash {
            get {
                return ResourceManager.GetString("JoinOnRightSideNameClash", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to SELECT `Project1`.`Id`,
        ///       `Project1`.`Name`,
        ///       `Project1`.`C2` AS `C1`,
        ///       `Project1`.`Id1`,
        ///       `Project1`.`AuthorId`,
        ///       `Project1`.`C1` AS `C2`,
        ///       `Project1`.`Id2`,
        ///       `Project1`.`Title`
        ///FROM   (SELECT `Extent1`.`Id`,
        ///               `Extent1`.`Name`,
        ///               `Join2`.`Id`  AS `Id1`,
        ///               `Join2`.`AuthorId`,
        ///               `Join2`.`Id1` AS `Id2`,
        ///               `Join2`.`Title`,
        ///               CASE
        ///                 WHEN ( `Join2`.`Id` IS NULL ) T [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string JoinUsingInclude {
            get {
                return ResourceManager.GetString("JoinUsingInclude", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to SELECT
        ///`Extent1`.`Id`, 
        ///`Extent1`.`Name`, 
        ///`Extent1`.`Address`, 
        ///`Extent1`.`City`, 
        ///`Extent1`.`State`, 
        ///`Extent1`.`ZipCode`
        ///FROM `Shops` AS `Extent1` INNER JOIN (SELECT
        ///MAX(`Extent2`.`ShopId`) AS `A1`
        ///FROM `Orders` AS `Extent2`) AS `GroupBy1` ON `Extent1`.`Id` = `GroupBy1`.`A1`.
        /// </summary>
        internal static string MaxInSubQuery1 {
            get {
                return ResourceManager.GetString("MaxInSubQuery1", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to SELECT
        ///`Extent1`.`Id`, 
        ///`Extent1`.`Name`, 
        ///`Extent1`.`Address`, 
        ///`Extent1`.`City`, 
        ///`Extent1`.`State`, 
        ///`Extent1`.`ZipCode`
        ///FROM `Shops` AS `Extent1` INNER JOIN (SELECT
        ///MAX(`Extent2`.`ShopId`) AS `A1`
        ///FROM `Orders` AS `Extent2`) AS `GroupBy1` ON `Extent1`.`Id` = `GroupBy1`.`A1`.
        /// </summary>
        internal static string MaxInSubQuery2 {
            get {
                return ResourceManager.GetString("MaxInSubQuery2", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to SELECT
        ///`GroupBy1`.`A1` AS `C1`
        ///FROM (SELECT
        ///MAX(`Extent1`.`MinAge`) AS `A1`
        ///FROM `Toys` AS `Extent1`) AS `GroupBy1`.
        /// </summary>
        internal static string MaxSimple {
            get {
                return ResourceManager.GetString("MaxSimple", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to SELECT
        ///`GroupBy1`.`A1` AS `C1`
        ///FROM (SELECT
        ///`Extent1`.`ShopId` AS `K1`, 
        ///MAX(`Extent1`.`Freight`) AS `A1`
        ///FROM `Orders` AS `Extent1`
        /// GROUP BY 
        ///`Extent1`.`ShopId`) AS `GroupBy1`.
        /// </summary>
        internal static string MaxWithGrouping {
            get {
                return ResourceManager.GetString("MaxWithGrouping", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to SELECT
        ///1 AS `C1`, 
        ///`GroupBy1`.`A1` AS `C2`
        ///FROM (SELECT
        ///MAX(`Extent1`.`Freight`) AS `A1`
        ///FROM `Orders` AS `Extent1`
        /// WHERE `Extent1`.`ShopId` = 1) AS `GroupBy1`.
        /// </summary>
        internal static string MaxWithPredicate {
            get {
                return ResourceManager.GetString("MaxWithPredicate", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to SELECT
        ///`GroupBy1`.`A1` AS `C1`
        ///FROM (SELECT
        ///MIN(`Extent1`.`MinAge`) AS `A1`
        ///FROM `Toys` AS `Extent1`) AS `GroupBy1`.
        /// </summary>
        internal static string MinSimple {
            get {
                return ResourceManager.GetString("MinSimple", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to SELECT
        ///`GroupBy1`.`A1` AS `C1`
        ///FROM (SELECT
        ///`Extent1`.`ShopId` AS `K1`, 
        ///MIN(`Extent1`.`Freight`) AS `A1`
        ///FROM `Orders` AS `Extent1`
        /// GROUP BY 
        ///`Extent1`.`ShopId`) AS `GroupBy1`.
        /// </summary>
        internal static string MinWithGrouping {
            get {
                return ResourceManager.GetString("MinWithGrouping", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to SELECT
        ///1 AS `C1`, 
        ///`GroupBy1`.`A1` AS `C2`
        ///FROM (SELECT
        ///MIN(`Extent1`.`Freight`) AS `A1`
        ///FROM `Orders` AS `Extent1`
        /// WHERE `Extent1`.`ShopId` = 2) AS `GroupBy1`.
        /// </summary>
        internal static string MinWithPredicate {
            get {
                return ResourceManager.GetString("MinWithPredicate", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to SELECT
        ///`Extent1`.`Id`, 
        ///`Extent1`.`Name`, 
        ///`Extent1`.`DateBegan`, 
        ///`Extent1`.`NumEmployees`, 
        ///`Extent1`.`Address`, 
        ///`Extent1`.`City`, 
        ///`Extent1`.`State`, 
        ///`Extent1`.`ZipCode`
        ///FROM `Companies` AS `Extent1`
        /// ORDER BY 
        ///`Extent1`.`Name` ASC.
        /// </summary>
        internal static string OrderBySimple {
            get {
                return ResourceManager.GetString("OrderBySimple", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to SELECT
        ///`Extent1`.`Id`, 
        ///`Extent1`.`Name`, 
        ///`Extent1`.`DateBegan`, 
        ///`Extent1`.`NumEmployees`, 
        ///`Extent1`.`Address`, 
        ///`Extent1`.`City`, 
        ///`Extent1`.`State`, 
        ///`Extent1`.`ZipCode`
        ///FROM `Companies` AS `Extent1`
        /// WHERE `Extent1`.`NumEmployees` &gt; 100
        /// ORDER BY 
        ///`Extent1`.`Name` ASC.
        /// </summary>
        internal static string OrderByWithPredicate {
            get {
                return ResourceManager.GetString("OrderByWithPredicate", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to SELECT
        ///`Extent1`.`Id`, 
        ///`Extent1`.`LastName`
        ///FROM `Employees` AS `Extent1` LEFT OUTER JOIN `SalariedEmployees` AS `Extent2` ON `Extent1`.`Id` = `Extent2`.`EmployeeId`
        /// WHERE `Extent1`.`Age` &gt; 20.
        /// </summary>
        internal static string SelectWithComplexType {
            get {
                return ResourceManager.GetString("SelectWithComplexType", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to SELECT
        ///`Extent1`.`Id`, 
        ///`Extent1`.`Name`, 
        ///`Extent2`.`Name` AS `Name1`
        ///FROM `Books` AS `Extent1` INNER JOIN `Authors` AS `Extent2` ON `Extent1`.`Author_id` = `Extent2`.`Id`.
        /// </summary>
        internal static string SimpleJoin {
            get {
                return ResourceManager.GetString("SimpleJoin", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to SELECT
        ///`Extent1`.`Id`, 
        ///`Extent1`.`Name`, 
        ///`Extent2`.`Name` AS `Name1`
        ///FROM `Books` AS `Extent1` INNER JOIN `Authors` AS `Extent2` ON `Extent1`.`Author_id` = `Extent2`.`Id`
        /// WHERE `Extent1`.`Pages` &gt; 300.
        /// </summary>
        internal static string SimpleJoinWithPredicate {
            get {
                return ResourceManager.GetString("SimpleJoinWithPredicate", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to SELECT
        ///`Extent1`.`Id`, 
        ///`Extent1`.`Name`, 
        ///`Extent1`.`MinAge`, 
        ///`Extent1`.`SupplierId`
        ///FROM `Toys` AS `Extent1`.
        /// </summary>
        internal static string SimpleSelect {
            get {
                return ResourceManager.GetString("SimpleSelect", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to SELECT
        ///`Extent1`.`Id`, 
        ///`Extent1`.`Name`, 
        ///`Extent1`.`MinAge`, 
        ///`Extent1`.`SupplierId`
        ///FROM `Toys` AS `Extent1`
        /// WHERE `Extent1`.`MinAge` = 4.
        /// </summary>
        internal static string SimpleSelectWithFilter {
            get {
                return ResourceManager.GetString("SimpleSelectWithFilter", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to SELECT
        ///`Extent1`.`Id`, 
        ///`Extent1`.`Name`, 
        ///`Extent1`.`MinAge`, 
        ///`Extent1`.`SupplierId`
        ///FROM `Toys` AS `Extent1`
        /// WHERE `Extent1`.`MinAge` &gt; @age.
        /// </summary>
        internal static string SimpleSelectWithParam {
            get {
                return ResourceManager.GetString("SimpleSelectWithParam", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to SELECT
        ///`Extent1`.`Id`, 
        ///`Extent1`.`Name`, 
        ///`Extent1`.`DateBegan`, 
        ///`Extent1`.`NumEmployees`, 
        ///`Extent1`.`Address`, 
        ///`Extent1`.`City`, 
        ///`Extent1`.`State`, 
        ///`Extent1`.`ZipCode`
        ///FROM `Companies` AS `Extent1`
        /// ORDER BY 
        ///`Extent1`.`Id` ASC LIMIT 3,18446744073709551615.
        /// </summary>
        internal static string Skip {
            get {
                return ResourceManager.GetString("Skip", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to SELECT
        ///`Extent1`.`Id`, 
        ///`Extent1`.`Name`, 
        ///`Extent1`.`DateBegan`, 
        ///`Extent1`.`NumEmployees`, 
        ///`Extent1`.`Address`, 
        ///`Extent1`.`City`, 
        ///`Extent1`.`State`, 
        ///`Extent1`.`ZipCode`
        ///FROM `Companies` AS `Extent1`
        /// ORDER BY 
        ///`Extent1`.`Id` ASC LIMIT 2,2.
        /// </summary>
        internal static string SkipAndTakeSimple {
            get {
                return ResourceManager.GetString("SkipAndTakeSimple", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to SELECT
        ///`Extent1`.`Id`, 
        ///`Extent1`.`Name`, 
        ///`Extent1`.`DateBegan`, 
        ///`Extent1`.`NumEmployees`, 
        ///`Extent1`.`Address`, 
        ///`Extent1`.`City`, 
        ///`Extent1`.`State`, 
        ///`Extent1`.`ZipCode`
        ///FROM `Companies` AS `Extent1`
        /// ORDER BY 
        ///`Extent1`.`Name` DESC LIMIT 2,2.
        /// </summary>
        internal static string SkipAndTakeWithOrdering {
            get {
                return ResourceManager.GetString("SkipAndTakeWithOrdering", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to SELECT
        ///`Project2`.`C1`, 
        ///`Project2`.`Id`, 
        ///`Project2`.`LastName`, 
        ///`Project2`.`FirstName`, 
        ///`Project2`.`Age`, 
        ///`Project2`.`C2`
        ///FROM (SELECT
        ///`Extent1`.`Id`, 
        ///`Extent1`.`LastName`, 
        ///`Extent1`.`FirstName`, 
        ///`Extent1`.`Age`, 
        ///CASE WHEN (NOT ((`Project1`.`C1` = 1) AND (`Project1`.`C1` IS NOT NULL))) THEN (@gp1)  ELSE (@gp2) END AS `C1`, 
        ///CASE WHEN (NOT ((`Project1`.`C1` = 1) AND (`Project1`.`C1` IS NOT NULL))) THEN (NULL)  ELSE (`Project1`.`Salary`) END AS `C2`
        ///FROM `Employees` AS `Extent1` LEFT OU [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string StartsWithTranslatedToLike {
            get {
                return ResourceManager.GetString("StartsWithTranslatedToLike", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to .
        /// </summary>
        internal static string String1 {
            get {
                return ResourceManager.GetString("String1", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to SELECT
        ///`GroupBy1`.`A1` AS `C1`
        ///FROM (SELECT
        ///SUM(`Extent1`.`MinAge`) AS `A1`
        ///FROM `Toys` AS `Extent1`) AS `GroupBy1`.
        /// </summary>
        internal static string SumSimple {
            get {
                return ResourceManager.GetString("SumSimple", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to SELECT
        ///`GroupBy1`.`A1` AS `C1`
        ///FROM (SELECT
        ///`Extent1`.`ShopId` AS `K1`, 
        ///SUM(`Extent1`.`Freight`) AS `A1`
        ///FROM `Orders` AS `Extent1`
        /// GROUP BY 
        ///`Extent1`.`ShopId`) AS `GroupBy1`.
        /// </summary>
        internal static string SumWithGrouping {
            get {
                return ResourceManager.GetString("SumWithGrouping", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to SELECT
        ///`GroupBy1`.`A1` AS `C1`
        ///FROM (SELECT
        ///SUM(`Extent1`.`Freight`) AS `A1`
        ///FROM `Orders` AS `Extent1`
        /// WHERE `Extent1`.`ShopId` = 2) AS `GroupBy1`.
        /// </summary>
        internal static string SumWithPredicate {
            get {
                return ResourceManager.GetString("SumWithPredicate", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to SELECT
        ///`Id`, 
        ///`Name`, 
        ///`DateBegan`, 
        ///`NumEmployees`, 
        ///`Address`, 
        ///`City`, 
        ///`State`, 
        ///`ZipCode`
        ///FROM `Companies` LIMIT 2.
        /// </summary>
        internal static string Top {
            get {
                return ResourceManager.GetString("Top", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to SELECT
        ///`UnionAll1`.`Id` AS `C1`, 
        ///`UnionAll1`.`Id1` AS `C2`, 
        ///`UnionAll1`.`Name` AS `C3`
        ///FROM (SELECT
        ///`Extent1`.`Id`, 
        ///`Extent1`.`Id` AS `Id1`, 
        ///`Extent1`.`Name`
        ///FROM `Toys` AS `Extent1` UNION ALL SELECT
        ///`Extent2`.`Id`, 
        ///`Extent2`.`Id` AS `Id1`, 
        ///`Extent2`.`Name`
        ///FROM `Companies` AS `Extent2`) AS `UnionAll1`.
        /// </summary>
        internal static string UnionAll {
            get {
                return ResourceManager.GetString("UnionAll", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to UPDATE `Products` SET `Name`=&apos;Acme 2&apos; WHERE `Id` = 1; SELECT `CreatedDate` FROM `Products` WHERE row_count() &gt; 0 and `Id` = 1.
        /// </summary>
        internal static string UpdateWithSelect {
            get {
                return ResourceManager.GetString("UpdateWithSelect", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to SELECT
        ///`Extent1`.`Id`, 
        ///`Extent1`.`Name`, 
        ///`Extent1`.`DateBegan`, 
        ///`Extent1`.`NumEmployees`, 
        ///`Extent1`.`Address`, 
        ///`Extent1`.`City`, 
        ///`Extent1`.`State`, 
        ///`Extent1`.`ZipCode`
        ///FROM `Companies` AS `Extent1`
        /// WHERE `Extent1`.`City` = @gp1.
        /// </summary>
        internal static string WhereLiteralOnRelation {
            get {
                return ResourceManager.GetString("WhereLiteralOnRelation", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to SELECT
        ///`Extent1`.`Id`, 
        ///`Extent1`.`Name`, 
        ///`Extent1`.`MinAge`, 
        ///`Extent1`.`SupplierId`
        ///FROM `Toys` AS `Extent1` INNER JOIN `Companies` AS `Extent2` ON `Extent1`.`SupplierId` = `Extent2`.`Id`
        /// WHERE `Extent2`.`State` = @gp1.
        /// </summary>
        internal static string WhereWithRelatedEntities1 {
            get {
                return ResourceManager.GetString("WhereWithRelatedEntities1", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to SELECT
        ///`Filter1`.`Id`, 
        ///`Filter1`.`Name`, 
        ///`Filter1`.`MinAge`, 
        ///`Filter1`.`SupplierId`
        ///FROM (SELECT
        ///`Extent1`.`Id`, 
        ///`Extent1`.`SupplierId`, 
        ///`Extent1`.`Name`, 
        ///`Extent1`.`MinAge`, 
        ///`Extent2`.`Id` AS `Id1`, 
        ///`Extent2`.`Name` AS `Name1`, 
        ///`Extent2`.`DateBegan`, 
        ///`Extent2`.`NumEmployees`, 
        ///`Extent2`.`Address`, 
        ///`Extent2`.`City`, 
        ///`Extent2`.`State`, 
        ///`Extent2`.`ZipCode`
        ///FROM `Toys` AS `Extent1` INNER JOIN `Companies` AS `Extent2` ON `Extent1`.`SupplierId` = `Extent2`.`Id`
        /// WHERE `Extent2`.`S [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string WhereWithRelatedEntities2 {
            get {
                return ResourceManager.GetString("WhereWithRelatedEntities2", resourceCulture);
            }
        }
    }
}
