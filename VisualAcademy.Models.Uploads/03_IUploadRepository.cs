﻿namespace VisualAcademy.Models.Uploads
{
    /// <summary>
    /// [4] Repository Interface
    /// </summary>
    public interface IUploadRepository : ICrudRepository<Upload>
    {
        Task<Tuple<int, int>> GetStatus(int parentId);
        Task<bool> DeleteAllByParentId(int parentId);
        Task<SortedList<int, double>> GetMonthlyCreateCountAsync();
    }
}
