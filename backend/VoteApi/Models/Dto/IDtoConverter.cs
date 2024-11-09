namespace VoteApi.Models.Dto;

public interface IDtoConverter<D,M> {
     M DtoToModel(D dto);
     D ModelToDto(M model);
}