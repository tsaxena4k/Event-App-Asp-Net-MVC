using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using TSEventApp.Application.Interfaces;
using TSEventApp.Application.Mapper;
using TSEventApp.Application.Models;
using TSEventApp.Core.Entities;
using TSEventApp.Core.IRepository;

namespace TSEventApp.Application.Services
{
    public class CommentService : ICommentService
    {
        private readonly ICommentRepository _commentRepository;

        public CommentService(ICommentRepository commentRepository)
        {
            this._commentRepository = commentRepository;
        }

        public async Task<int> PostComment(CommentModel response)
        {
            var mapped = ObjectMapper.Mapper.Map<Comment>(response);
            if (mapped == null)
                throw new Exception($"Entity could not be mapped.");

            return await _commentRepository.PostComment(mapped);
        }

        public async Task<IList<CommentModel>> GetComments()
        {
            var commentList = await _commentRepository.GetComments();
            var mapped = ObjectMapper.Mapper.Map<IList<CommentModel>>(commentList);
            return mapped;

        }
        public async Task<CommentModel> ViewComment(int commentId)
        {
            var _comment = await _commentRepository.ViewComment(commentId);
            var mapped = ObjectMapper.Mapper.Map<CommentModel>(_comment);
            return mapped;
        }
        public int EditComment(CommentModel response)
        {
            var mapped = ObjectMapper.Mapper.Map<Comment>(response);
            if (mapped == null)
                throw new Exception($"Entity could not be mapped.");

            return _commentRepository.EditComment(mapped);
        }
    }
}
