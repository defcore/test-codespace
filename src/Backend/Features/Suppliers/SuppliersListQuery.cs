using MediatR;

namespace Backend.Features.Suppliers;


public class SupplierListQuery : IRequest<List<SupplierListQueryResponse>>
{
    public string? Name { get; set; }
}

public class SupplierListQueryResponse
{
    public int Id { get; set; }
    public string Name { get; set; } = "";
    public string Address { get; set; } = "";
    public string Email { get; set; } = "";
    public string Phone { get; set; } = "";
}

internal class SupplierListQueryHandler : IRequestHandler<SupplierListQuery, List<SupplierListQueryResponse>>
{
    private readonly BackendContext context;

    public SupplierListQueryHandler(BackendContext context)
    {
        this.context = context;
    }

    public async Task<List<SupplierListQueryResponse>> Handle(SupplierListQuery request, CancellationToken cancellationToken)
    {
        var query = context.Suppliers.AsQueryable();
        if (!string.IsNullOrEmpty(request.Name))
            query = query.Where(q => q.Name.ToLower().Contains(request.Name.ToLower()));

        return await query
            .OrderBy(q => q.Name)
            .Select(q => new SupplierListQueryResponse
            {
                Id = q.Id,
                Name = q.Name,
                Address = q.Address,
                Email = q.Email,
                Phone = q.Phone,
            }).ToListAsync();
    }
}