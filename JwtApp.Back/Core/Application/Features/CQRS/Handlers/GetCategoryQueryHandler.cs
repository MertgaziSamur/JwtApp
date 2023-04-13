using AutoMapper;
using JwtApp.Back.Core.Application.Dto;
using JwtApp.Back.Core.Application.Features.CQRS.Queries;
using JwtApp.Back.Core.Application.Interfaces;
using JwtApp.Back.Core.Domain;
using MediatR;

namespace JwtApp.Back.Core.Application.Features.CQRS.Handlers
{
    public class GetCategoryQueryHandler : IRequestHandler<GetCategoryQueryRequest, CategoryListDto?>
    {
        private readonly IMapper _mapper;
        private readonly IRepository<Category> _repository;

        public GetCategoryQueryHandler(IMapper mapper, IRepository<Category> repository)
        {
            _mapper = mapper;
            _repository = repository;
        }

        public async Task<CategoryListDto?> Handle(GetCategoryQueryRequest request, CancellationToken cancellationToken)
        {
            var result = await _repository.GetByFilterAsync(x => x.Id == request.Id);
            return _mapper.Map<CategoryListDto>(result);
        }
    }
}
