using UnityEngine;
using System.Collections;

public static partial class JSONTemplates {

	/*
	 * Vector2
	 */
	public static Vector2 ToVector2(JSONObject obj) {
		float x = obj["x"] ? obj["x"].n : 0;
		float y = obj["y"] ? obj["y"].n : 0;
		return new Vector2(x, y);
	}
	public static JSONObject FromVector2(Vector2 v) {
		JSONObject vdata = new JSONObject(JSONObject.Type.OBJECT);
		if(v.x != 0)	vdata.AddField("x", v.x);
		if(v.y != 0)	vdata.AddField("y", v.y);
		return vdata;
	}
	/*
	 * Vector3
	 */
	public static JSONObject FromVector3(Vector3 v) {
		JSONObject vdata = new JSONObject(JSONObject.Type.OBJECT);
		if(v.x != 0)	vdata.AddField("x", v.x);
		if(v.y != 0)	vdata.AddField("y", v.y);
		if(v.z != 0)	vdata.AddField("z", v.z);
		return vdata;
	}
	public static Vector3 ToVector3(JSONObject obj) {
		float x = obj["x"] ? obj["x"].n : 0;
		float y = obj["y"] ? obj["y"].n : 0;
		float z = obj["z"] ? obj["z"].n : 0;
		return new Vector3(x, y, z);
	}
	/*
	 * Vector4
	 */
	public static JSONObject FromVector4(Vector4 v) {
		JSONObject vdata = new JSONObject(JSONObject.Type.OBJECT);
		if(v.x != 0)	vdata.AddField("x", v.x);
		if(v.y != 0)	vdata.AddField("y", v.y);
		if(v.z != 0)	vdata.AddField("z", v.z);
		if(v.w != 0)	vdata.AddField("w", v.w);
		return vdata;
	}
	public static Vector4 ToVector4(JSONObject obj) {
		float x = obj["x"] ? obj["x"].n : 0;
		float y = obj["y"] ? obj["y"].n : 0;
		float z = obj["z"] ? obj["z"].n : 0;
		float w = obj["w"] ? obj["w"].n : 0;
		return new Vector4(x, y, z, w);
	}
	/*
	 * Matrix4x4
	 */
	public static JSONObject FromMatrix4x4(Matrix4x4 m) {
		JSONObject mdata = new JSONObject(JSONObject.Type.OBJECT);
		if(m.m00 != 0) mdata.AddField("m00", m.m00);
		if(m.m01 != 0) mdata.AddField("m01", m.m01);
		if(m.m02 != 0) mdata.AddField("m02", m.m02);
		if(m.m03 != 0) mdata.AddField("m03", m.m03);
		if(m.m10 != 0) mdata.AddField("m10", m.m10);
		if(m.m11 != 0) mdata.AddField("m11", m.m11);
		if(m.m12 != 0) mdata.AddField("m12", m.m12);
		if(m.m13 != 0) mdata.AddField("m13", m.m13);
		if(m.m20 != 0) mdata.AddField("m20", m.m20);
		if(m.m21 != 0) mdata.AddField("m21", m.m21);
		if(m.m22 != 0) mdata.AddField("m22", m.m22);
		if(m.m23 != 0) mdata.AddField("m23", m.m23);
		if(m.m30 != 0) mdata.AddField("m30", m.m30);
		if(m.m31 != 0) mdata.AddField("m31", m.m31);
		if(m.m32 != 0) mdata.AddField("m32", m.m32);
		if(m.m33 != 0) mdata.AddField("m33", m.m33);
		return mdata;
	}
	public static Matrix4x4 ToMatrix4x4(JSONObject obj) {
		Matrix4x4 result = new Matrix4x4();
		if(obj["m00"]) result.m00 = obj["m00"].n;
		if(obj["m01"]) result.m01 = obj["m01"].n;
		if(obj["m02"]) result.m02 = obj["m02"].n;
		if(obj["m03"]) result.m03 = obj["m03"].n;
		if(obj["m10"]) result.m10 = obj["m10"].n;
		if(obj["m11"]) result.m11 = obj["m11"].n;
		if(obj["m12"]) result.m12 = obj["m12"].n;
		if(obj["m13"]) result.m13 = obj["m13"].n;
		if(obj["m20"]) result.m20 = obj["m20"].n;
		if(obj["m21"]) result.m21 = obj["m21"].n;
		if(obj["m22"]) result.m22 = obj["m22"].n;
		if(obj["m23"]) result.m23 = obj["m23"].n;
		if(obj["m30"]) result.m30 = obj["m30"].n;
		if(obj["m31"]) result.m31 = obj["m31"].n;
		if(obj["m32"]) result.m32 = obj["m32"].n;
		if(obj["m33"]) result.m33 = obj["m33"].n;
		return result;
	}
	/*
	 * Quaternion
	 */
	public static JSONObject FromQuaternion(Quaternion q) {
		JSONObject qdata = new JSONObject(JSONObject.Type.OBJECT);
		if(q.w != 0)	qdata.AddField("w", q.w);
		if(q.x != 0)	qdata.AddField("x", q.x);
		if(q.y != 0)	qdata.AddField("y", q.y);
		if(q.z != 0)	qdata.AddField("z", q.z);
		return qdata;
	}
	public static Quaternion ToQuaternion(JSONObject obj) {
		float x = obj["x"] ? obj["x"].n : 0;
		float y = obj["y"] ? obj["y"].n : 0;
		float z = obj["z"] ? obj["z"].n : 0;
		float w = obj["w"] ? obj["w"].n : 0;
		return new Quaternion(x, y, z, w);
	}
	/*
	 * Color
	 */
	public static JSONObject FromColor(Color c) {
		JSONObject cdata = new JSONObject(JSONObject.Type.OBJECT);
		if(c.r != 0)	cdata.AddField("r", c.r);
		if(c.g != 0)	cdata.AddField("g", c.g);
		if(c.b != 0)	cdata.AddField("b", c.b);
		if(c.a != 0)	cdata.AddField("a", c.a);
		return cdata;
	}
	public static Color ToColor(JSONObject obj) {
		Color c = new Color();
		for(int i = 0; i < obj.Count; i++) {
			switch((string)obj.keys[i]) {
			case "r": c.r = obj[i].n; break;
			case "g": c.g = obj[i].n; break;
			case "b": c.b = obj[i].n; break;
			case "a": c.a = obj[i].n; break;
			}
		}
		return c;
	}
	/*
	 * Layer Mask
	 */
	public static JSONObject FromLayerMask(LayerMask l) {
		JSONObject result = JSONObject.obj;
		result.AddField("value", l.value);
		return result;
	}
	public static LayerMask ToLayerMask(JSONObject obj) {
		LayerMask l = new LayerMask();
		l.value = (int)obj["value"].n;
		return l;
	}
	public static JSONObject FromRect(Rect r) {
		JSONObject result = JSONObject.obj;
		if(r.x != 0)		result.AddField("x", r.x);
		if(r.y != 0)		result.AddField("y", r.y);
		if(r.height != 0)	result.AddField("height", r.height);
		if(r.width != 0)	result.AddField("width", r.width);
		return result;
	}
	public static Rect ToRect(JSONObject obj) {
		Rect r = new Rect();
		for(int i = 0; i < obj.Count; i++) {
			switch((string)obj.keys[i]) {
			case "x": r.x = obj[i].n; break;
			case "y": r.y = obj[i].n; break;
			case "height": r.height = obj[i].n; break;
			case "width": r.width = obj[i].n; break;
			}
		}
		return r;
	}
	public static JSONObject FromRectOffset(RectOffset r) {
		JSONObject result = JSONObject.obj;
		if(r.bottom != 0)		result.AddField("bottom", r.bottom);
		if(r.left != 0)			result.AddField("left", r.left);
		if(r.right != 0)		result.AddField("right", r.right);
		if(r.top != 0)			result.AddField("top", r.top);
		return result;
	}
	public static RectOffset ToRectOffset(JSONObject obj) {
		RectOffset r = new RectOffset();
		for(int i = 0; i < obj.Count; i++) {
			switch((string)obj.keys[i]) {
			case "bottom": r.bottom = (int)obj[i].n; break;
			case "left": r.left = (int)obj[i].n; break;
			case "right": r.right =	(int)obj[i].n; break;
			case "top": r.top = (int)obj[i].n; break;
			}
		}
		return r;
	}
}
