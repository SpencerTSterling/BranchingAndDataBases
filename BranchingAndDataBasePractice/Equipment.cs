using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BranchingAndDataBasePractice
{
    /// <summary>
    /// Represents a single piece of computer equipment
    /// </summary>
    class Equipment
    {
        #region Properties

        /// <summary>
        /// The primary key of the equipment
        /// </summary>
        public int EqiupmentId { get; set; }

        /// <summary>
        /// The name of the equipment
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// The retail price of the eqiupment
        /// </summary>
        public double Price { get; set; }

        #endregion
    }
}
