using MediatR;

namespace Catalog.API.Products.CreateProduct
{
    public record CreateProductCommand(string Name, List<string> Category, Guid Description, Guid ImageFile, decimal Price)
        : IRequest<CreateProductResult>;
    public record CreateProductResult(Guid Id);
    internal class CreateProductCommandHandler : IRequestHandler<CreateProductCommand, CreateProductResult>
    {
        public Task<CreateProductResult> Handle(CreateProductCommand request, CancellationToken cancellationToken)
        {
            // Logic to create a product would go here
            // For now, we return a dummy result
            return Task.FromResult(new CreateProductResult(Guid.NewGuid()));
        }
    }
    
}
