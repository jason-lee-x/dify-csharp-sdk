namespace DifyAI.Interfaces
{
    public interface IDifyAIServiceFactory
    {
        /// <summary>
        /// 根据名称获取 IDifyAIService 实例
        /// </summary>
        /// <param name="name">注册时指定的名称</param>
        IDifyAIService CreateService(string name);
    }
}
