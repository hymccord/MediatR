using System.IO;
using System.Threading;
using System.Threading.Tasks;
using MediatR.Pipeline;

namespace MediatR.Benchmarks
{
    public class GenericRequestPostProcessor<TRequest, TResponse> : IRequestPostProcessor<TRequest, TResponse>
        where TRequest : IRequest<TResponse>
    {
        private readonly TextWriter _writer;

        public GenericRequestPostProcessor(TextWriter writer)
        {
            _writer = writer;
        }

        public Task Process(TRequest request, TResponse response, CancellationToken cancellationToken)
        {
            return _writer.WriteLineAsync("- All Done");
        }
    }
}