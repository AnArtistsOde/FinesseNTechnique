using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// tt: FRUSTUM CULLING - objects outside of FOV arent rendered, saving resources
///removing these objects not rendered is FC which unity does by default 
///playing with FOV- smaller FOV gets smaller amount of things rendered . 
///VS
///Occlusion Culling: Great for complex, large 3d scenes
///Best for static objects within scene. Objs not rendered if came doesnt see them(OCCLUDER STATIC)
///Thing that are not rendered because they are behind the occluder static are the (OCCLUDEE STATIC)
///Objs need a mesh rendered to be affected by occlusion culling. 
/// </summary>
public static class  NotesOnCulling 
{
  
}
