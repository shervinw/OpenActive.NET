namespace OpenActive.NET
{
    using System;
    using System.Collections;
    using System.Collections.Generic;

    /// <summary>
    /// A single or list of values which can be any of the specified types.
    /// </summary>
    /// <typeparam name="T1">The first type the values can take.</typeparam>
    /// <typeparam name="T2">The second type the values can take.</typeparam>
    /// <typeparam name="T3">The third type the values can take.</typeparam>
    /// <seealso cref="IValue" />
    public struct SingleValues<T1, T2, T3> : IValue, IEquatable<SingleValues<T1, T2, T3>>
    {
        private readonly T1 value1;
        private readonly T2 value2;
        private readonly T3 value3;

        /// <summary>
        /// Initializes a new instance of the <see cref="SingleValues{T1,T2,T3}"/> class.
        /// </summary>
        /// <param name="value">The value of type <typeparamref name="T1"/>.</param>
        public SingleValues(T1 value)
        {
            this.value1 = value;
            this.value2 = default;
            this.value3 = default;
            this.HasValue1 = true;
            this.HasValue2 = false;
            this.HasValue3 = false;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SingleValues{T1,T2,T3}"/> class.
        /// </summary>
        /// <param name="value">The value of type <typeparamref name="T2"/>.</param>
        public SingleValues(T2 value)
        {
            this.value1 = default;
            this.value2 = value;
            this.value3 = default;
            this.HasValue1 = false;
            this.HasValue2 = true;
            this.HasValue3 = false;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SingleValues{T1,T2,T3}"/> class.
        /// </summary>
        /// <param name="value">The value of type <typeparamref name="T3"/>.</param>
        public SingleValues(T3 value)
        {
            this.value1 = default;
            this.value2 = default;
            this.value3 = value;
            this.HasValue1 = false;
            this.HasValue2 = false;
            this.HasValue3 = true;
        }

        /// <summary>
        /// Gets the value of type <typeparamref name="T1" />. This is internal as the order of values may change over time.
        /// </summary>
        internal T1 Value1 => this.value1;

        /// <summary>
        /// Gets the value of type <typeparamref name="T2" />. This is internal as the order of values may change over time.
        /// </summary>
        internal T2 Value2 => this.value2;

        /// <summary>
        /// Gets the value of type <typeparamref name="T3" />. This is internal as the order of values may change over time.
        /// </summary>
        internal T3 Value3 => this.value3;


        /// <summary>
        /// Gets the nullable primative representing the instance, if it is of the type specified.
        /// </summary>
        public Nullable<T> GetPrimative<T>() where T : struct
        {
            if (typeof(T1) == typeof(T) || typeof(T1) == typeof(Nullable<T>))
            {
                if (HasValue1)
                {
                    return (T)(object)this.value1;
                }
                else
                {
                    return null;
                }
            }
            else if (typeof(T2) == typeof(T) || typeof(T2) == typeof(Nullable<T>))
            {
                if (HasValue2)
                {
                    return (T)(object)this.value2;
                }
                else
                {
                    return null;
                }
            }
            else if (typeof(T3) == typeof(T) || typeof(T3) == typeof(Nullable<T>))
            {
                if (HasValue3)
                {
                    return (T)(object)this.value3;
                }
                else
                {
                    return null;
                }
            }
            throw new TypeAccessException("GetPrimative was used with a type that is not available.");
        }

        /// <summary>
        /// Gets the object representing the instance, if it is of the type specified.
        /// </summary>
        public T GetClass<T>() where T : class
        {
            if (typeof(T1) == typeof(T))
            {
                if (HasValue1)
                {
                    return (T)(object)this.value1;
                }
                else
                {
                    return null;
                }
            }
            else if (typeof(T2) == typeof(T))
            {
                if (HasValue2)
                {
                    return (T)(object)this.value2;
                }
                else
                {
                    return null;
                }
            }
            else if (typeof(T3) == typeof(T))
            {
                if (HasValue3)
                {
                    return (T)(object)this.value3;
                }
                else
                {
                    return null;
                }
            }
            throw new TypeAccessException("GetClass was used with a type that is not available.");
        }

        /// <summary>
        /// Checks whether the instance represents the specified type
        /// </summary>
        /// <typeparam name="T">Type to check</typeparam>
        /// <returns>true/false if the matching type does / does not have a value, throws exception if T is unknown</returns>
        public bool HasValueOfType<T>()
        {
            if (typeof(T1) == typeof(T))
            {
                return HasValue1;
            }
            else if (typeof(T2) == typeof(T))
            {
                return HasValue2;
            }
            else if (typeof(T3) == typeof(T))
            {
                return HasValue3;
            }
            throw new TypeAccessException("HasValueOfType was used with a type that is not available.");
        }

        /// <summary>
        /// Gets the non-null object representing the instance.
        /// </summary>
        public object Value
        {
            get
            {
                if (HasValue1)
                {
                    return this.value1;
                }
                else if (HasValue2)
                {
                    return this.value2;
                }
                else if (HasValue3)
                {
                    return this.value3;
                }

                return null;
            }
        }

        /// <summary>
        /// Gets a value indicating whether this instance has a value.
        /// </summary>
        public bool HasValue => this.HasValue1 || this.HasValue2 || this.HasValue3;

        /// <summary>
        /// Gets whether the value of type <typeparamref name="T1" /> has a value. This is internal as the order of values may change over time.
        /// </summary>
        internal bool HasValue1 { get; }

        /// <summary>
        /// Gets whether the value of type <typeparamref name="T2" /> has a value. This is internal as the order of values may change over time.
        /// </summary>
        internal bool HasValue2 { get; }

        /// <summary>
        /// Gets whether the value of type <typeparamref name="T3" /> has a value. This is internal as the order of values may change over time.
        /// </summary>
        internal bool HasValue3 { get; }


        /// <summary>
        /// Performs an implicit conversion from <typeparamref name="T1"/> to <see cref="SingleValues{T1,T2}"/>.
        /// </summary>
        /// <param name="item">The single item value.</param>
        /// <returns>The result of the conversion.</returns>
        public static implicit operator SingleValues<T1, T2, T3>(T1 item) => item.IsNullEmptyOrWhiteSpace() ? default : new SingleValues<T1, T2, T3>(item);

        /// <summary>
        /// Performs an implicit conversion from <typeparamref name="T2"/> to <see cref="SingleValues{T1,T2}"/>.
        /// </summary>
        /// <param name="item">The single item value.</param>
        /// <returns>The result of the conversion.</returns>
        public static implicit operator SingleValues<T1, T2, T3>(T2 item) => item.IsNullEmptyOrWhiteSpace() ? default : new SingleValues<T1, T2, T3>(item);

        /// <summary>
        /// Performs an implicit conversion from <typeparamref name="T3"/> to <see cref="SingleValues{T1,T2}"/>.
        /// </summary>
        /// <param name="item">The single item value.</param>
        /// <returns>The result of the conversion.</returns>
        public static implicit operator SingleValues<T1, T2, T3>(T3 item) => item.IsNullEmptyOrWhiteSpace() ? default : new SingleValues<T1, T2, T3>(item);


        /// <summary>
        /// Implements the operator ==.
        /// </summary>
        /// <param name="left">The left.</param>
        /// <param name="right">The right.</param>
        /// <returns>
        /// The result of the operator.
        /// </returns>
        public static bool operator ==(SingleValues<T1, T2, T3> left, SingleValues<T1, T2, T3> right) => left.Equals(right);

        /// <summary>
        /// Implements the operator !=.
        /// </summary>
        /// <param name="left">The left.</param>
        /// <param name="right">The right.</param>
        /// <returns>
        /// The result of the operator.
        /// </returns>
        public static bool operator !=(SingleValues<T1, T2, T3> left, SingleValues<T1, T2, T3> right) => !(left == right);

        /// <summary>
        /// Indicates whether the current object is equal to another object of the same type.
        /// </summary>
        /// <param name="other">An object to compare with this object.</param>
        /// <returns>
        /// true if the current object is equal to the <paramref name="other" /> parameter; otherwise, false.
        /// </returns>
        public bool Equals(SingleValues<T1, T2, T3> other)
        {
            if (other == null)
            {
                return false;
            }
            else if (other.HasValue1)
            {
                if (this.HasValue1)
                {
                    return this.Value1.Equals(other.Value1);
                }
            }
            else if (other.HasValue2)
            {
                if (this.HasValue2)
                {
                    return this.Value2.Equals(other.Value2);
                }
            }
            else if (other.HasValue3)
            {
                if (this.HasValue3)
                {
                    return this.Value3.Equals(other.Value3);
                }
            }
            else if (!other.HasValue && !this.HasValue)
            {
                return true;
            }

            return false;
        }

        /// <summary>
        /// Determines whether the specified <see cref="object" />, is equal to this instance.
        /// </summary>
        /// <param name="obj">The <see cref="object" /> to compare with this instance.</param>
        /// <returns>
        /// <c>true</c> if the specified <see cref="object" /> is equal to this instance; otherwise, <c>false</c>.
        /// </returns>
        public override bool Equals(object obj) => obj is SingleValues<T1, T2, T3> ? this.Equals((SingleValues<T1, T2, T3>)obj) : false;

        /// <summary>
        /// Implements ToString
        /// </summary>
        /// <returns>
        /// A string representing the relevant value
        /// </returns>
        public override string ToString()
        {
            if (this.HasValue1)
            {
                return this.Value1.ToString();
            }
            else if (this.HasValue2)
            {
                return this.Value2.ToString();
            }
            else if (this.HasValue3)
            {
                return this.Value3.ToString();
            }
            return ((string)null).ToString();
        }

        /// <summary>
        /// Returns a hash code for this instance.
        /// </summary>
        /// <returns>
        /// A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table.
        /// </returns>
        public override int GetHashCode() => Schema.NET.HashCode.Of(this.Value1).And(this.Value2).And(this.Value3);
    }
}
