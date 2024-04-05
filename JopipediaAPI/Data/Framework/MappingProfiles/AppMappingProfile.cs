using AutoMapper;
using JopipediaAPI.Data.DTO;
using JopipediaAPI.Data.DTO.Award;
using JopipediaAPI.Data.DTO.Quiz;
using JopipediaAPI.Data.DTO.Rank;
using JopipediaAPI.Data.DTO.Topic;
using JopipediaAPI.Data.DTO.User;
using JopipediaAPI.Data.DTO.UserLevel;
using JopipediaAPI.Data.DTO.UserRole;
using JopipediaAPI.Data.Model;

namespace JopipediaAPI.Data.Framework.MappingProfiles;

public class AppMappingProfile: Profile
{
    public AppMappingProfile()
    {
        #region UserRegion
            CreateMap<User, SignUpPayloadDTO>().ReverseMap();
            CreateMap<User, UpdateUserPayloadDTO>().ReverseMap();
            CreateMap<User, UserDTO>().ReverseMap();
            CreateMap<UserRole, UserRoleDTO>().ReverseMap();
            CreateMap<UserRank, UserRankDTO>().ReverseMap();
            CreateMap<UserLevel, UserLevelDTO>().ReverseMap();
            CreateMap<Award, AwardDTO>().ReverseMap();
            CreateMap<Topic, TopicDTO>().ReverseMap();
            CreateMap<Quiz, QuizDTO>().ReverseMap();
        #endregion
    }
}