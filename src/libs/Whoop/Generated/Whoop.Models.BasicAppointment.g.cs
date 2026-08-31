#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Whoop
{
    /// <summary>
    ///
    /// </summary>
    public readonly partial struct BasicAppointment : global::System.IEquatable<BasicAppointment>
    {
        /// <summary>
        /// Appointment information
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Whoop.Appointment? Appointment { get; init; }
#else
        public global::Whoop.Appointment? Appointment { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Appointment))]
#endif
        public bool IsAppointment => Appointment != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickAppointment(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Whoop.Appointment? value)
        {
            value = Appointment;
            return IsAppointment;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Whoop.Appointment PickAppointment() => IsAppointment
            ? Appointment!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Appointment' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator BasicAppointment(global::Whoop.Appointment value) => new BasicAppointment((global::Whoop.Appointment?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Whoop.Appointment?(BasicAppointment @this) => @this.Appointment;

        /// <summary>
        ///
        /// </summary>
        public BasicAppointment(global::Whoop.Appointment? value)
        {
            Appointment = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static BasicAppointment FromAppointment(global::Whoop.Appointment? value) => new BasicAppointment(value);

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            Appointment as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            Appointment?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsAppointment;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Whoop.Appointment, TResult>? appointment = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsAppointment && appointment != null)
            {
                return appointment(Appointment!);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::Whoop.Appointment>? appointment = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsAppointment)
            {
                appointment?.Invoke(Appointment!);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::Whoop.Appointment>? appointment = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsAppointment)
            {
                appointment?.Invoke(Appointment!);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Appointment,
                typeof(global::Whoop.Appointment),
            };
            const int offset = unchecked((int)2166136261);
            const int prime = 16777619;
            static int HashCodeAggregator(int hashCode, object? value) => value == null
                ? (hashCode ^ 0) * prime
                : (hashCode ^ value.GetHashCode()) * prime;

            return global::System.Linq.Enumerable.Aggregate(fields, offset, HashCodeAggregator);
        }

        /// <summary>
        ///
        /// </summary>
        public bool Equals(BasicAppointment other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Whoop.Appointment?>.Default.Equals(Appointment, other.Appointment)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(BasicAppointment obj1, BasicAppointment obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<BasicAppointment>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(BasicAppointment obj1, BasicAppointment obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is BasicAppointment o && Equals(o);
        }
    }
}
