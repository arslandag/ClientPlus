namespace ClientPlus.Domain.Common;

public static class Errors
{
    public static class General
    {
        public static Error Iternal(string message)
            => new("iternal", message);

        public static Error Unexpected()
            => new("unexpecret", "unexpecret");

        public static Error NotFound(Guid? id = null)
        {
            var forId = id == null ? "" : $" for Id '{id}'";
            return new("record.not.found", $"record not found{forId}");
        }

        public static Error ValueIsInvalid(string? name = null)
        {
            var label = name ?? "Value";
            return new("value.is.invalid", $"{label} is invalid");
        }

        public static Error ValueIsRequired(string? name = null)
        {
            var label = name ?? "Value";
            return new("value.is.required", $"{label} is required");
        }

        public static Error InvalidLength(string? name = null)
        {
            var label = name == null ? " " : " " + name + " ";
            return new("length.is.invalid", $"invalid{label}length");
        }

        public static Error SaveFailure(string? name = null)
        {
            var label = name ?? "Value";
            return new("record.save.failure", $"{label} failed to save");
        }
    }
    
    public static class Kafka
    {
        public static Error PersistFail()
        {
            return new("kafka.persist.fail", "Fail to persist message");
        }
    }
}