namespace Encog.Neural.Networks.Training
{
    /// <summary>
    /// Specifies that a training algorithm has the concept of a learning rate.
    /// This allows it to be used with strategies that automatically adjust the
    /// learning rate.
    /// </summary>
    ///
    public interface ILearningRate
    {
        /// <summary>
        /// Set the learning rate.
        /// </summary>
        ///
        /// <value>The new learning rate</value>
        double LearningRate { /// <returns>The learning rate.</returns>
            get;
            /// <summary>
            /// Set the learning rate.
            /// </summary>
            ///
            /// <param name="rate">The new learning rate</param>
            set; }
    }
}