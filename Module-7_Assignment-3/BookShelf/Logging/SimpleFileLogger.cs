using Microsoft.Extensions.Logging;
using System;
using System.IO; // <-- needed for File and Path

namespace BookShelf.Logging
{
    public sealed class SimpleFileLoggerProvider : ILoggerProvider
    {
        private readonly string _path;
        private readonly object _lock = new();

        public SimpleFileLoggerProvider(string path)
        {
            _path = path;
            var dir = Path.GetDirectoryName(_path);
            if (!string.IsNullOrWhiteSpace(dir))
            {
                Directory.CreateDirectory(dir);
            }
        }

        public ILogger CreateLogger(string categoryName) => new SimpleFileLogger(_path, _lock, categoryName);

        public void Dispose() { }

        private sealed class SimpleFileLogger : ILogger
        {
            private readonly string _path;
            private readonly object _lock;
            private readonly string _category;

            public SimpleFileLogger(string path, object @lock, string category)
            {
                _path = path;
                _lock = @lock;
                _category = category;
            }

            public IDisposable BeginScope<TState>(TState state) => null!; // or default!

            public bool IsEnabled(LogLevel logLevel) => true;

            public void Log<TState>(LogLevel logLevel, EventId eventId, TState state, Exception exception, Func<TState, Exception, string> formatter)
            {
                if (formatter == null) return;
                var line = $"{DateTimeOffset.Now:u} [{logLevel}] {_category}: {formatter(state, exception)}";
                if (exception != null) line += Environment.NewLine + exception;
                lock (_lock)
                {
                    File.AppendAllText(_path, line + Environment.NewLine);
                }
            }
        }
    }

    public static class SimpleFileLoggerExtensions
    {
        public static ILoggingBuilder AddSimpleFile(this ILoggingBuilder builder, string path)
        {
            builder.AddProvider(new SimpleFileLoggerProvider(path));
            return builder;
        }
    }
}
