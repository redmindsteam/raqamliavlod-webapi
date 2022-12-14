using RaqamliAvlod.Application.Exceptions;
using RaqamliAvlod.Application.Utils;
using RaqamliAvlod.Application.ViewModels.Courses;
using RaqamliAvlod.DataAccess.Interfaces;
using RaqamliAvlod.Domain.Entities.Courses;
using RaqamliAvlod.Infrastructure.Service.Dtos;
using RaqamliAvlod.Infrastructure.Service.Helpers;
using RaqamliAvlod.Infrastructure.Service.Interfaces.Common;
using RaqamliAvlod.Infrastructure.Service.Interfaces.Courses;
using System.Net;
using YoutubeExplode;

namespace RaqamliAvlod.Infrastructure.Service.Services.Courses;

public class CourseVideoService : ICourseVideoService
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IPaginatorService _paginator;

    public CourseVideoService(IUnitOfWork unitOfWork,
        IPaginatorService paginator)
    {
        _unitOfWork = unitOfWork;
        _paginator = paginator;
    }
    public async Task<bool> CreateAsync(CourseVideoCreateDto dto)
    {
        var course = await _unitOfWork.Courses.FindByIdAsync(dto.CourseId);

        if (course is null)
            throw new StatusCodeException(HttpStatusCode.BadRequest, "Course not found!");

        var video = await new YoutubeClient().Videos.GetAsync(YouTubeVideoIdExtractor(dto.Link));

        var courseVideoCreate = (CourseVideo)dto;

        courseVideoCreate.CourseId = dto.CourseId;
        courseVideoCreate.YouTubeLink = video.Url;
        courseVideoCreate.Title = video.Title;
        courseVideoCreate.Description = video.Description;
        courseVideoCreate.Duration = DateTime.Parse(video.Duration!.Value.ToString()).ToString("HH:mm:ss");
        courseVideoCreate.YouTubeThumbnail = video.Thumbnails.OrderByDescending(p => p.Resolution.Height).FirstOrDefault()!.Url;
        courseVideoCreate.CreatedAt = TimeHelper.GetCurrentDateTime();

        var res = await _unitOfWork.CourseVideos.CreateAsync(courseVideoCreate);

        return res is not null;
    }

    public async Task<bool> DeleteAsync(long videoId)
    {
        var courseVideo = await _unitOfWork.CourseVideos.FindByIdAsync(videoId);

        if (courseVideo is null)
            throw new StatusCodeException(HttpStatusCode.BadRequest, "Video not found!");

        var result = await _unitOfWork.CourseVideos.DeleteAsync(videoId);

        return result is not null;
    }

    public async Task<IEnumerable<CourseVideoGetAllViewModel>> GetAllAsync(long courseId, PaginationParams @params)
    {
        var courseVideos = await _unitOfWork.CourseVideos.GetAllByCourseIdAsync(courseId, @params);
        _paginator.ToPagenator(courseVideos.MetaData);

        return courseVideos;
    }

    public async Task<CourseVideoGetViewModel> GetAsync(long videoId)
    {
        var video = await _unitOfWork.CourseVideos.FindByIdAsync(videoId);

        if (video is null)
            throw new StatusCodeException(HttpStatusCode.BadRequest, "Video not found!");

        video.ViewCount += 1;
        await _unitOfWork.CourseVideos.UpdateAsync(videoId, video);

        var videoView = (CourseVideoGetViewModel)video;

        return videoView;
    }
    public async Task<bool> UpdateAsync(long videoId, CourseVideoUpdateDto dto)
    {
        var video = await _unitOfWork.CourseVideos.FindByIdAsync(videoId);
        if (video is null)
            throw new StatusCodeException(HttpStatusCode.BadRequest, "Video not found!");

        var videoLink = await new YoutubeClient().Videos.GetAsync(YouTubeVideoIdExtractor(dto.Link));

        video.YouTubeLink = videoLink.Url;
        video.Title = videoLink.Title;
        video.Description = videoLink.Description;
        video.YouTubeThumbnail = videoLink.Thumbnails.OrderByDescending(p => p.Resolution.Height).FirstOrDefault()!.Url;
        video.Duration = DateTime.Parse(videoLink.Duration!.Value.ToString()).ToString("HH:mm:ss");

        var res = await _unitOfWork.CourseVideos.UpdateAsync(videoId, video);

        return res is not null;
    }


    private string YouTubeVideoIdExtractor(string link)
    {
        if (!IsYouTubeLink(link))
            throw new StatusCodeException(HttpStatusCode.BadRequest, "Invalid Youtube link!");

        return link;
    }
    private bool IsYouTubeLink(string link)
    {
        try
        {
            Uri uri = new Uri(link);

            return uri.Host == "www.youtube.com" || uri.Host == "youtube.com" ||
                        uri.Host == "www.youtu.be" || uri.Host == "youtu.be";
        }
        catch (Exception)
        {
            return false;
        }
    }
}
