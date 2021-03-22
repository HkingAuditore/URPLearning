using UnityEngine;
using UnityEngine.Rendering;

namespace Rendering.CustomRenderingPipeline
{
    [CreateAssetMenu(menuName = "Rendering/CustomRenderingPipeline")]
    public class CustomRenderingPipelineAsset : RenderPipelineAsset
    {
        protected override RenderPipeline CreatePipeline()
        {
            return null;
        }
    }
}
