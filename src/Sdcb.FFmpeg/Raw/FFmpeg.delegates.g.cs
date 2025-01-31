using System;
using System.Runtime.InteropServices;

#pragma warning disable 169
#pragma warning disable CS0649
#pragma warning disable CS0108
namespace Sdcb.FFmpeg.Raw
{
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate string AVClass_item_name (void* ctx);
    public unsafe record struct AVClass_item_name_func(IntPtr Pointer)
    {
        public static implicit operator AVClass_item_name_func(AVClass_item_name func) => new(func switch
        {
            null => IntPtr.Zero,
            _ => Marshal.GetFunctionPointerForDelegate(func)
        });
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate void* AVClass_child_next (void* obj, void* prev);
    public unsafe record struct AVClass_child_next_func(IntPtr Pointer)
    {
        public static implicit operator AVClass_child_next_func(AVClass_child_next func) => new(func switch
        {
            null => IntPtr.Zero,
            _ => Marshal.GetFunctionPointerForDelegate(func)
        });
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate AVClass* AVClass_child_class_next (AVClass* prev);
    public unsafe record struct AVClass_child_class_next_func(IntPtr Pointer)
    {
        public static implicit operator AVClass_child_class_next_func(AVClass_child_class_next func) => new(func switch
        {
            null => IntPtr.Zero,
            _ => Marshal.GetFunctionPointerForDelegate(func)
        });
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate AVClassCategory AVClass_get_category (void* ctx);
    public unsafe record struct AVClass_get_category_func(IntPtr Pointer)
    {
        public static implicit operator AVClass_get_category_func(AVClass_get_category func) => new(func switch
        {
            null => IntPtr.Zero,
            _ => Marshal.GetFunctionPointerForDelegate(func)
        });
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate int AVClass_query_ranges (AVOptionRanges** p0, void* obj, [MarshalAs(UnmanagedType.LPUTF8Str)] string key, int flags);
    public unsafe record struct AVClass_query_ranges_func(IntPtr Pointer)
    {
        public static implicit operator AVClass_query_ranges_func(AVClass_query_ranges func) => new(func switch
        {
            null => IntPtr.Zero,
            _ => Marshal.GetFunctionPointerForDelegate(func)
        });
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate AVClass* AVClass_child_class_iterate (void** iter);
    public unsafe record struct AVClass_child_class_iterate_func(IntPtr Pointer)
    {
        public static implicit operator AVClass_child_class_iterate_func(AVClass_child_class_iterate func) => new(func switch
        {
            null => IntPtr.Zero,
            _ => Marshal.GetFunctionPointerForDelegate(func)
        });
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate void av_log_set_callback_callback (void* p0, int p1, [MarshalAs(UnmanagedType.LPUTF8Str)] string p2, byte* p3);
    public unsafe record struct av_log_set_callback_callback_func(IntPtr Pointer)
    {
        public static implicit operator av_log_set_callback_callback_func(av_log_set_callback_callback func) => new(func switch
        {
            null => IntPtr.Zero,
            _ => Marshal.GetFunctionPointerForDelegate(func)
        });
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate void av_fifo_generic_peek_at_func (void* p0, void* p1, int p2);
    public unsafe record struct av_fifo_generic_peek_at_func_func(IntPtr Pointer)
    {
        public static implicit operator av_fifo_generic_peek_at_func_func(av_fifo_generic_peek_at_func func) => new(func switch
        {
            null => IntPtr.Zero,
            _ => Marshal.GetFunctionPointerForDelegate(func)
        });
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate void av_fifo_generic_peek_func (void* p0, void* p1, int p2);
    public unsafe record struct av_fifo_generic_peek_func_func(IntPtr Pointer)
    {
        public static implicit operator av_fifo_generic_peek_func_func(av_fifo_generic_peek_func func) => new(func switch
        {
            null => IntPtr.Zero,
            _ => Marshal.GetFunctionPointerForDelegate(func)
        });
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate void av_fifo_generic_read_func (void* p0, void* p1, int p2);
    public unsafe record struct av_fifo_generic_read_func_func(IntPtr Pointer)
    {
        public static implicit operator av_fifo_generic_read_func_func(av_fifo_generic_read_func func) => new(func switch
        {
            null => IntPtr.Zero,
            _ => Marshal.GetFunctionPointerForDelegate(func)
        });
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate int av_fifo_generic_write_func (void* p0, void* p1, int p2);
    public unsafe record struct av_fifo_generic_write_func_func(IntPtr Pointer)
    {
        public static implicit operator av_fifo_generic_write_func_func(av_fifo_generic_write_func func) => new(func switch
        {
            null => IntPtr.Zero,
            _ => Marshal.GetFunctionPointerForDelegate(func)
        });
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate void av_buffer_create_free (void* opaque, byte* data);
    public unsafe record struct av_buffer_create_free_func(IntPtr Pointer)
    {
        public static implicit operator av_buffer_create_free_func(av_buffer_create_free func) => new(func switch
        {
            null => IntPtr.Zero,
            _ => Marshal.GetFunctionPointerForDelegate(func)
        });
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate AVBufferRef* av_buffer_pool_init_alloc (int size);
    public unsafe record struct av_buffer_pool_init_alloc_func(IntPtr Pointer)
    {
        public static implicit operator av_buffer_pool_init_alloc_func(av_buffer_pool_init_alloc func) => new(func switch
        {
            null => IntPtr.Zero,
            _ => Marshal.GetFunctionPointerForDelegate(func)
        });
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate AVBufferRef* av_buffer_pool_init2_alloc (void* opaque, int size);
    public unsafe record struct av_buffer_pool_init2_alloc_func(IntPtr Pointer)
    {
        public static implicit operator av_buffer_pool_init2_alloc_func(av_buffer_pool_init2_alloc func) => new(func switch
        {
            null => IntPtr.Zero,
            _ => Marshal.GetFunctionPointerForDelegate(func)
        });
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate void av_buffer_pool_init2_pool_free (void* opaque);
    public unsafe record struct av_buffer_pool_init2_pool_free_func(IntPtr Pointer)
    {
        public static implicit operator av_buffer_pool_init2_pool_free_func(av_buffer_pool_init2_pool_free func) => new(func switch
        {
            null => IntPtr.Zero,
            _ => Marshal.GetFunctionPointerForDelegate(func)
        });
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate int av_tree_find_cmp (void* key, void* b);
    public unsafe record struct av_tree_find_cmp_func(IntPtr Pointer)
    {
        public static implicit operator av_tree_find_cmp_func(av_tree_find_cmp func) => new(func switch
        {
            null => IntPtr.Zero,
            _ => Marshal.GetFunctionPointerForDelegate(func)
        });
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate int av_tree_insert_cmp (void* key, void* b);
    public unsafe record struct av_tree_insert_cmp_func(IntPtr Pointer)
    {
        public static implicit operator av_tree_insert_cmp_func(av_tree_insert_cmp func) => new(func switch
        {
            null => IntPtr.Zero,
            _ => Marshal.GetFunctionPointerForDelegate(func)
        });
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate int av_tree_enumerate_cmp (void* opaque, void* elem);
    public unsafe record struct av_tree_enumerate_cmp_func(IntPtr Pointer)
    {
        public static implicit operator av_tree_enumerate_cmp_func(av_tree_enumerate_cmp func) => new(func switch
        {
            null => IntPtr.Zero,
            _ => Marshal.GetFunctionPointerForDelegate(func)
        });
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate int av_tree_enumerate_enu (void* opaque, void* elem);
    public unsafe record struct av_tree_enumerate_enu_func(IntPtr Pointer)
    {
        public static implicit operator av_tree_enumerate_enu_func(av_tree_enumerate_enu func) => new(func switch
        {
            null => IntPtr.Zero,
            _ => Marshal.GetFunctionPointerForDelegate(func)
        });
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate void AVHWDeviceContext_free (AVHWDeviceContext* ctx);
    public unsafe record struct AVHWDeviceContext_free_func(IntPtr Pointer)
    {
        public static implicit operator AVHWDeviceContext_free_func(AVHWDeviceContext_free func) => new(func switch
        {
            null => IntPtr.Zero,
            _ => Marshal.GetFunctionPointerForDelegate(func)
        });
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate void AVHWFramesContext_free (AVHWFramesContext* ctx);
    public unsafe record struct AVHWFramesContext_free_func(IntPtr Pointer)
    {
        public static implicit operator AVHWFramesContext_free_func(AVHWFramesContext_free func) => new(func switch
        {
            null => IntPtr.Zero,
            _ => Marshal.GetFunctionPointerForDelegate(func)
        });
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate void AVD3D11VADeviceContext_lock (void* lock_ctx);
    public unsafe record struct AVD3D11VADeviceContext_lock_func(IntPtr Pointer)
    {
        public static implicit operator AVD3D11VADeviceContext_lock_func(AVD3D11VADeviceContext_lock func) => new(func switch
        {
            null => IntPtr.Zero,
            _ => Marshal.GetFunctionPointerForDelegate(func)
        });
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate void AVD3D11VADeviceContext_unlock (void* lock_ctx);
    public unsafe record struct AVD3D11VADeviceContext_unlock_func(IntPtr Pointer)
    {
        public static implicit operator AVD3D11VADeviceContext_unlock_func(AVD3D11VADeviceContext_unlock func) => new(func switch
        {
            null => IntPtr.Zero,
            _ => Marshal.GetFunctionPointerForDelegate(func)
        });
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate int AVCodec_update_thread_context (AVCodecContext* dst, AVCodecContext* src);
    public unsafe record struct AVCodec_update_thread_context_func(IntPtr Pointer)
    {
        public static implicit operator AVCodec_update_thread_context_func(AVCodec_update_thread_context func) => new(func switch
        {
            null => IntPtr.Zero,
            _ => Marshal.GetFunctionPointerForDelegate(func)
        });
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate void AVCodec_init_static_data (AVCodec* codec);
    public unsafe record struct AVCodec_init_static_data_func(IntPtr Pointer)
    {
        public static implicit operator AVCodec_init_static_data_func(AVCodec_init_static_data func) => new(func switch
        {
            null => IntPtr.Zero,
            _ => Marshal.GetFunctionPointerForDelegate(func)
        });
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate int AVCodec_init (AVCodecContext* p0);
    public unsafe record struct AVCodec_init_func(IntPtr Pointer)
    {
        public static implicit operator AVCodec_init_func(AVCodec_init func) => new(func switch
        {
            null => IntPtr.Zero,
            _ => Marshal.GetFunctionPointerForDelegate(func)
        });
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate int AVCodec_encode_sub (AVCodecContext* p0, byte* buf, int buf_size, AVSubtitle* sub);
    public unsafe record struct AVCodec_encode_sub_func(IntPtr Pointer)
    {
        public static implicit operator AVCodec_encode_sub_func(AVCodec_encode_sub func) => new(func switch
        {
            null => IntPtr.Zero,
            _ => Marshal.GetFunctionPointerForDelegate(func)
        });
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate int AVCodec_encode2 (AVCodecContext* avctx, AVPacket* avpkt, AVFrame* frame, int* got_packet_ptr);
    public unsafe record struct AVCodec_encode2_func(IntPtr Pointer)
    {
        public static implicit operator AVCodec_encode2_func(AVCodec_encode2 func) => new(func switch
        {
            null => IntPtr.Zero,
            _ => Marshal.GetFunctionPointerForDelegate(func)
        });
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate int AVCodec_decode (AVCodecContext* avctx, void* outdata, int* got_frame_ptr, AVPacket* avpkt);
    public unsafe record struct AVCodec_decode_func(IntPtr Pointer)
    {
        public static implicit operator AVCodec_decode_func(AVCodec_decode func) => new(func switch
        {
            null => IntPtr.Zero,
            _ => Marshal.GetFunctionPointerForDelegate(func)
        });
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate int AVCodec_close (AVCodecContext* p0);
    public unsafe record struct AVCodec_close_func(IntPtr Pointer)
    {
        public static implicit operator AVCodec_close_func(AVCodec_close func) => new(func switch
        {
            null => IntPtr.Zero,
            _ => Marshal.GetFunctionPointerForDelegate(func)
        });
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate int AVCodec_receive_packet (AVCodecContext* avctx, AVPacket* avpkt);
    public unsafe record struct AVCodec_receive_packet_func(IntPtr Pointer)
    {
        public static implicit operator AVCodec_receive_packet_func(AVCodec_receive_packet func) => new(func switch
        {
            null => IntPtr.Zero,
            _ => Marshal.GetFunctionPointerForDelegate(func)
        });
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate int AVCodec_receive_frame (AVCodecContext* avctx, AVFrame* frame);
    public unsafe record struct AVCodec_receive_frame_func(IntPtr Pointer)
    {
        public static implicit operator AVCodec_receive_frame_func(AVCodec_receive_frame func) => new(func switch
        {
            null => IntPtr.Zero,
            _ => Marshal.GetFunctionPointerForDelegate(func)
        });
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate void AVCodec_flush (AVCodecContext* p0);
    public unsafe record struct AVCodec_flush_func(IntPtr Pointer)
    {
        public static implicit operator AVCodec_flush_func(AVCodec_flush func) => new(func switch
        {
            null => IntPtr.Zero,
            _ => Marshal.GetFunctionPointerForDelegate(func)
        });
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate void AVCodecContext_draw_horiz_band (AVCodecContext* s, AVFrame* src, ref int_array8 offset, int y, int type, int height);
    public unsafe record struct AVCodecContext_draw_horiz_band_func(IntPtr Pointer)
    {
        public static implicit operator AVCodecContext_draw_horiz_band_func(AVCodecContext_draw_horiz_band func) => new(func switch
        {
            null => IntPtr.Zero,
            _ => Marshal.GetFunctionPointerForDelegate(func)
        });
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate AVPixelFormat AVCodecContext_get_format (AVCodecContext* s, AVPixelFormat* fmt);
    public unsafe record struct AVCodecContext_get_format_func(IntPtr Pointer)
    {
        public static implicit operator AVCodecContext_get_format_func(AVCodecContext_get_format func) => new(func switch
        {
            null => IntPtr.Zero,
            _ => Marshal.GetFunctionPointerForDelegate(func)
        });
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate int AVCodecContext_get_buffer2 (AVCodecContext* s, AVFrame* frame, int flags);
    public unsafe record struct AVCodecContext_get_buffer2_func(IntPtr Pointer)
    {
        public static implicit operator AVCodecContext_get_buffer2_func(AVCodecContext_get_buffer2 func) => new(func switch
        {
            null => IntPtr.Zero,
            _ => Marshal.GetFunctionPointerForDelegate(func)
        });
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate void AVCodecContext_rtp_callback (AVCodecContext* avctx, void* data, int size, int mb_nb);
    public unsafe record struct AVCodecContext_rtp_callback_func(IntPtr Pointer)
    {
        public static implicit operator AVCodecContext_rtp_callback_func(AVCodecContext_rtp_callback func) => new(func switch
        {
            null => IntPtr.Zero,
            _ => Marshal.GetFunctionPointerForDelegate(func)
        });
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate int AVHWAccel_alloc_frame (AVCodecContext* avctx, AVFrame* frame);
    public unsafe record struct AVHWAccel_alloc_frame_func(IntPtr Pointer)
    {
        public static implicit operator AVHWAccel_alloc_frame_func(AVHWAccel_alloc_frame func) => new(func switch
        {
            null => IntPtr.Zero,
            _ => Marshal.GetFunctionPointerForDelegate(func)
        });
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate int AVHWAccel_start_frame (AVCodecContext* avctx, byte* buf, uint buf_size);
    public unsafe record struct AVHWAccel_start_frame_func(IntPtr Pointer)
    {
        public static implicit operator AVHWAccel_start_frame_func(AVHWAccel_start_frame func) => new(func switch
        {
            null => IntPtr.Zero,
            _ => Marshal.GetFunctionPointerForDelegate(func)
        });
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate int AVHWAccel_decode_params (AVCodecContext* avctx, int type, byte* buf, uint buf_size);
    public unsafe record struct AVHWAccel_decode_params_func(IntPtr Pointer)
    {
        public static implicit operator AVHWAccel_decode_params_func(AVHWAccel_decode_params func) => new(func switch
        {
            null => IntPtr.Zero,
            _ => Marshal.GetFunctionPointerForDelegate(func)
        });
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate int AVHWAccel_decode_slice (AVCodecContext* avctx, byte* buf, uint buf_size);
    public unsafe record struct AVHWAccel_decode_slice_func(IntPtr Pointer)
    {
        public static implicit operator AVHWAccel_decode_slice_func(AVHWAccel_decode_slice func) => new(func switch
        {
            null => IntPtr.Zero,
            _ => Marshal.GetFunctionPointerForDelegate(func)
        });
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate int AVHWAccel_end_frame (AVCodecContext* avctx);
    public unsafe record struct AVHWAccel_end_frame_func(IntPtr Pointer)
    {
        public static implicit operator AVHWAccel_end_frame_func(AVHWAccel_end_frame func) => new(func switch
        {
            null => IntPtr.Zero,
            _ => Marshal.GetFunctionPointerForDelegate(func)
        });
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate void AVHWAccel_decode_mb (MpegEncContext* s);
    public unsafe record struct AVHWAccel_decode_mb_func(IntPtr Pointer)
    {
        public static implicit operator AVHWAccel_decode_mb_func(AVHWAccel_decode_mb func) => new(func switch
        {
            null => IntPtr.Zero,
            _ => Marshal.GetFunctionPointerForDelegate(func)
        });
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate int AVHWAccel_init (AVCodecContext* avctx);
    public unsafe record struct AVHWAccel_init_func(IntPtr Pointer)
    {
        public static implicit operator AVHWAccel_init_func(AVHWAccel_init func) => new(func switch
        {
            null => IntPtr.Zero,
            _ => Marshal.GetFunctionPointerForDelegate(func)
        });
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate int AVHWAccel_uninit (AVCodecContext* avctx);
    public unsafe record struct AVHWAccel_uninit_func(IntPtr Pointer)
    {
        public static implicit operator AVHWAccel_uninit_func(AVHWAccel_uninit func) => new(func switch
        {
            null => IntPtr.Zero,
            _ => Marshal.GetFunctionPointerForDelegate(func)
        });
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate int AVHWAccel_frame_params (AVCodecContext* avctx, AVBufferRef* hw_frames_ctx);
    public unsafe record struct AVHWAccel_frame_params_func(IntPtr Pointer)
    {
        public static implicit operator AVHWAccel_frame_params_func(AVHWAccel_frame_params func) => new(func switch
        {
            null => IntPtr.Zero,
            _ => Marshal.GetFunctionPointerForDelegate(func)
        });
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate int AVCodecContext_execute (AVCodecContext* c, func_func func, void* arg2, int* ret, int count, int size);
    public unsafe record struct AVCodecContext_execute_func(IntPtr Pointer)
    {
        public static implicit operator AVCodecContext_execute_func(AVCodecContext_execute func) => new(func switch
        {
            null => IntPtr.Zero,
            _ => Marshal.GetFunctionPointerForDelegate(func)
        });
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate int AVCodecContext_execute2 (AVCodecContext* c, func_func func, void* arg2, int* ret, int count);
    public unsafe record struct AVCodecContext_execute2_func(IntPtr Pointer)
    {
        public static implicit operator AVCodecContext_execute2_func(AVCodecContext_execute2 func) => new(func switch
        {
            null => IntPtr.Zero,
            _ => Marshal.GetFunctionPointerForDelegate(func)
        });
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate int AVCodecContext_get_encode_buffer (AVCodecContext* s, AVPacket* pkt, int flags);
    public unsafe record struct AVCodecContext_get_encode_buffer_func(IntPtr Pointer)
    {
        public static implicit operator AVCodecContext_get_encode_buffer_func(AVCodecContext_get_encode_buffer func) => new(func switch
        {
            null => IntPtr.Zero,
            _ => Marshal.GetFunctionPointerForDelegate(func)
        });
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate int AVCodecParser_parser_init (AVCodecParserContext* s);
    public unsafe record struct AVCodecParser_parser_init_func(IntPtr Pointer)
    {
        public static implicit operator AVCodecParser_parser_init_func(AVCodecParser_parser_init func) => new(func switch
        {
            null => IntPtr.Zero,
            _ => Marshal.GetFunctionPointerForDelegate(func)
        });
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate int AVCodecParser_parser_parse (AVCodecParserContext* s, AVCodecContext* avctx, byte** poutbuf, int* poutbuf_size, byte* buf, int buf_size);
    public unsafe record struct AVCodecParser_parser_parse_func(IntPtr Pointer)
    {
        public static implicit operator AVCodecParser_parser_parse_func(AVCodecParser_parser_parse func) => new(func switch
        {
            null => IntPtr.Zero,
            _ => Marshal.GetFunctionPointerForDelegate(func)
        });
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate void AVCodecParser_parser_close (AVCodecParserContext* s);
    public unsafe record struct AVCodecParser_parser_close_func(IntPtr Pointer)
    {
        public static implicit operator AVCodecParser_parser_close_func(AVCodecParser_parser_close func) => new(func switch
        {
            null => IntPtr.Zero,
            _ => Marshal.GetFunctionPointerForDelegate(func)
        });
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate int AVCodecParser_split (AVCodecContext* avctx, byte* buf, int buf_size);
    public unsafe record struct AVCodecParser_split_func(IntPtr Pointer)
    {
        public static implicit operator AVCodecParser_split_func(AVCodecParser_split func) => new(func switch
        {
            null => IntPtr.Zero,
            _ => Marshal.GetFunctionPointerForDelegate(func)
        });
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate int AVBitStreamFilter_init (AVBSFContext* ctx);
    public unsafe record struct AVBitStreamFilter_init_func(IntPtr Pointer)
    {
        public static implicit operator AVBitStreamFilter_init_func(AVBitStreamFilter_init func) => new(func switch
        {
            null => IntPtr.Zero,
            _ => Marshal.GetFunctionPointerForDelegate(func)
        });
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate int AVBitStreamFilter_filter (AVBSFContext* ctx, AVPacket* pkt);
    public unsafe record struct AVBitStreamFilter_filter_func(IntPtr Pointer)
    {
        public static implicit operator AVBitStreamFilter_filter_func(AVBitStreamFilter_filter func) => new(func switch
        {
            null => IntPtr.Zero,
            _ => Marshal.GetFunctionPointerForDelegate(func)
        });
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate void AVBitStreamFilter_close (AVBSFContext* ctx);
    public unsafe record struct AVBitStreamFilter_close_func(IntPtr Pointer)
    {
        public static implicit operator AVBitStreamFilter_close_func(AVBitStreamFilter_close func) => new(func switch
        {
            null => IntPtr.Zero,
            _ => Marshal.GetFunctionPointerForDelegate(func)
        });
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate void AVBitStreamFilter_flush (AVBSFContext* ctx);
    public unsafe record struct AVBitStreamFilter_flush_func(IntPtr Pointer)
    {
        public static implicit operator AVBitStreamFilter_flush_func(AVBitStreamFilter_flush func) => new(func switch
        {
            null => IntPtr.Zero,
            _ => Marshal.GetFunctionPointerForDelegate(func)
        });
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate int avcodec_default_execute_func (AVCodecContext* c2, void* arg2);
    public unsafe record struct avcodec_default_execute_func_func(IntPtr Pointer)
    {
        public static implicit operator avcodec_default_execute_func_func(avcodec_default_execute_func func) => new(func switch
        {
            null => IntPtr.Zero,
            _ => Marshal.GetFunctionPointerForDelegate(func)
        });
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate int avcodec_default_execute2_func (AVCodecContext* c2, void* arg2, int p2, int p3);
    public unsafe record struct avcodec_default_execute2_func_func(IntPtr Pointer)
    {
        public static implicit operator avcodec_default_execute2_func_func(avcodec_default_execute2_func func) => new(func switch
        {
            null => IntPtr.Zero,
            _ => Marshal.GetFunctionPointerForDelegate(func)
        });
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate int av_lockmgr_register_cb (void** mutex, AVLockOp op);
    public unsafe record struct av_lockmgr_register_cb_func(IntPtr Pointer)
    {
        public static implicit operator av_lockmgr_register_cb_func(av_lockmgr_register_cb func) => new(func switch
        {
            null => IntPtr.Zero,
            _ => Marshal.GetFunctionPointerForDelegate(func)
        });
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate int AVInputFormat_read_probe (AVProbeData* p0);
    public unsafe record struct AVInputFormat_read_probe_func(IntPtr Pointer)
    {
        public static implicit operator AVInputFormat_read_probe_func(AVInputFormat_read_probe func) => new(func switch
        {
            null => IntPtr.Zero,
            _ => Marshal.GetFunctionPointerForDelegate(func)
        });
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate int AVInputFormat_read_header (AVFormatContext* p0);
    public unsafe record struct AVInputFormat_read_header_func(IntPtr Pointer)
    {
        public static implicit operator AVInputFormat_read_header_func(AVInputFormat_read_header func) => new(func switch
        {
            null => IntPtr.Zero,
            _ => Marshal.GetFunctionPointerForDelegate(func)
        });
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate int AVInputFormat_read_packet (AVFormatContext* p0, AVPacket* pkt);
    public unsafe record struct AVInputFormat_read_packet_func(IntPtr Pointer)
    {
        public static implicit operator AVInputFormat_read_packet_func(AVInputFormat_read_packet func) => new(func switch
        {
            null => IntPtr.Zero,
            _ => Marshal.GetFunctionPointerForDelegate(func)
        });
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate int AVInputFormat_read_close (AVFormatContext* p0);
    public unsafe record struct AVInputFormat_read_close_func(IntPtr Pointer)
    {
        public static implicit operator AVInputFormat_read_close_func(AVInputFormat_read_close func) => new(func switch
        {
            null => IntPtr.Zero,
            _ => Marshal.GetFunctionPointerForDelegate(func)
        });
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate int AVInputFormat_read_seek (AVFormatContext* p0, int stream_index, long timestamp, int flags);
    public unsafe record struct AVInputFormat_read_seek_func(IntPtr Pointer)
    {
        public static implicit operator AVInputFormat_read_seek_func(AVInputFormat_read_seek func) => new(func switch
        {
            null => IntPtr.Zero,
            _ => Marshal.GetFunctionPointerForDelegate(func)
        });
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate long AVInputFormat_read_timestamp (AVFormatContext* s, int stream_index, long* pos, long pos_limit);
    public unsafe record struct AVInputFormat_read_timestamp_func(IntPtr Pointer)
    {
        public static implicit operator AVInputFormat_read_timestamp_func(AVInputFormat_read_timestamp func) => new(func switch
        {
            null => IntPtr.Zero,
            _ => Marshal.GetFunctionPointerForDelegate(func)
        });
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate int AVInputFormat_read_play (AVFormatContext* p0);
    public unsafe record struct AVInputFormat_read_play_func(IntPtr Pointer)
    {
        public static implicit operator AVInputFormat_read_play_func(AVInputFormat_read_play func) => new(func switch
        {
            null => IntPtr.Zero,
            _ => Marshal.GetFunctionPointerForDelegate(func)
        });
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate int AVInputFormat_read_pause (AVFormatContext* p0);
    public unsafe record struct AVInputFormat_read_pause_func(IntPtr Pointer)
    {
        public static implicit operator AVInputFormat_read_pause_func(AVInputFormat_read_pause func) => new(func switch
        {
            null => IntPtr.Zero,
            _ => Marshal.GetFunctionPointerForDelegate(func)
        });
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate int AVInputFormat_read_seek2 (AVFormatContext* s, int stream_index, long min_ts, long ts, long max_ts, int flags);
    public unsafe record struct AVInputFormat_read_seek2_func(IntPtr Pointer)
    {
        public static implicit operator AVInputFormat_read_seek2_func(AVInputFormat_read_seek2 func) => new(func switch
        {
            null => IntPtr.Zero,
            _ => Marshal.GetFunctionPointerForDelegate(func)
        });
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate int AVInputFormat_get_device_list (AVFormatContext* s, AVDeviceInfoList* device_list);
    public unsafe record struct AVInputFormat_get_device_list_func(IntPtr Pointer)
    {
        public static implicit operator AVInputFormat_get_device_list_func(AVInputFormat_get_device_list func) => new(func switch
        {
            null => IntPtr.Zero,
            _ => Marshal.GetFunctionPointerForDelegate(func)
        });
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate int AVInputFormat_create_device_capabilities (AVFormatContext* s, AVDeviceCapabilitiesQuery* caps);
    public unsafe record struct AVInputFormat_create_device_capabilities_func(IntPtr Pointer)
    {
        public static implicit operator AVInputFormat_create_device_capabilities_func(AVInputFormat_create_device_capabilities func) => new(func switch
        {
            null => IntPtr.Zero,
            _ => Marshal.GetFunctionPointerForDelegate(func)
        });
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate int AVInputFormat_free_device_capabilities (AVFormatContext* s, AVDeviceCapabilitiesQuery* caps);
    public unsafe record struct AVInputFormat_free_device_capabilities_func(IntPtr Pointer)
    {
        public static implicit operator AVInputFormat_free_device_capabilities_func(AVInputFormat_free_device_capabilities func) => new(func switch
        {
            null => IntPtr.Zero,
            _ => Marshal.GetFunctionPointerForDelegate(func)
        });
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate int AVIOContext_read_packet (void* opaque, byte* buf, int buf_size);
    public unsafe record struct AVIOContext_read_packet_func(IntPtr Pointer)
    {
        public static implicit operator AVIOContext_read_packet_func(AVIOContext_read_packet func) => new(func switch
        {
            null => IntPtr.Zero,
            _ => Marshal.GetFunctionPointerForDelegate(func)
        });
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate int AVIOContext_write_packet (void* opaque, byte* buf, int buf_size);
    public unsafe record struct AVIOContext_write_packet_func(IntPtr Pointer)
    {
        public static implicit operator AVIOContext_write_packet_func(AVIOContext_write_packet func) => new(func switch
        {
            null => IntPtr.Zero,
            _ => Marshal.GetFunctionPointerForDelegate(func)
        });
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate long AVIOContext_seek (void* opaque, long offset, int whence);
    public unsafe record struct AVIOContext_seek_func(IntPtr Pointer)
    {
        public static implicit operator AVIOContext_seek_func(AVIOContext_seek func) => new(func switch
        {
            null => IntPtr.Zero,
            _ => Marshal.GetFunctionPointerForDelegate(func)
        });
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate ulong AVIOContext_update_checksum (ulong checksum, byte* buf, uint size);
    public unsafe record struct AVIOContext_update_checksum_func(IntPtr Pointer)
    {
        public static implicit operator AVIOContext_update_checksum_func(AVIOContext_update_checksum func) => new(func switch
        {
            null => IntPtr.Zero,
            _ => Marshal.GetFunctionPointerForDelegate(func)
        });
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate int AVIOContext_read_pause (void* opaque, int pause);
    public unsafe record struct AVIOContext_read_pause_func(IntPtr Pointer)
    {
        public static implicit operator AVIOContext_read_pause_func(AVIOContext_read_pause func) => new(func switch
        {
            null => IntPtr.Zero,
            _ => Marshal.GetFunctionPointerForDelegate(func)
        });
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate long AVIOContext_read_seek (void* opaque, int stream_index, long timestamp, int flags);
    public unsafe record struct AVIOContext_read_seek_func(IntPtr Pointer)
    {
        public static implicit operator AVIOContext_read_seek_func(AVIOContext_read_seek func) => new(func switch
        {
            null => IntPtr.Zero,
            _ => Marshal.GetFunctionPointerForDelegate(func)
        });
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate int AVIOContext_write_data_type (void* opaque, byte* buf, int buf_size, AVIODataMarkerType type, long time);
    public unsafe record struct AVIOContext_write_data_type_func(IntPtr Pointer)
    {
        public static implicit operator AVIOContext_write_data_type_func(AVIOContext_write_data_type func) => new(func switch
        {
            null => IntPtr.Zero,
            _ => Marshal.GetFunctionPointerForDelegate(func)
        });
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate int AVIOContext_short_seek_get (void* opaque);
    public unsafe record struct AVIOContext_short_seek_get_func(IntPtr Pointer)
    {
        public static implicit operator AVIOContext_short_seek_get_func(AVIOContext_short_seek_get func) => new(func switch
        {
            null => IntPtr.Zero,
            _ => Marshal.GetFunctionPointerForDelegate(func)
        });
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate int AVIOInterruptCB_callback (void* p0);
    public unsafe record struct AVIOInterruptCB_callback_func(IntPtr Pointer)
    {
        public static implicit operator AVIOInterruptCB_callback_func(AVIOInterruptCB_callback func) => new(func switch
        {
            null => IntPtr.Zero,
            _ => Marshal.GetFunctionPointerForDelegate(func)
        });
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate int AVFormatContext_control_message_cb (AVFormatContext* s, int type, void* data, ulong data_size);
    public unsafe record struct AVFormatContext_control_message_cb_func(IntPtr Pointer)
    {
        public static implicit operator AVFormatContext_control_message_cb_func(AVFormatContext_control_message_cb func) => new(func switch
        {
            null => IntPtr.Zero,
            _ => Marshal.GetFunctionPointerForDelegate(func)
        });
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate int AVFormatContext_open_cb (AVFormatContext* s, AVIOContext** p, [MarshalAs(UnmanagedType.LPUTF8Str)] string url, int flags, AVIOInterruptCB* int_cb, AVDictionary** options);
    public unsafe record struct AVFormatContext_open_cb_func(IntPtr Pointer)
    {
        public static implicit operator AVFormatContext_open_cb_func(AVFormatContext_open_cb func) => new(func switch
        {
            null => IntPtr.Zero,
            _ => Marshal.GetFunctionPointerForDelegate(func)
        });
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate int AVFormatContext_io_open (AVFormatContext* s, AVIOContext** pb, [MarshalAs(UnmanagedType.LPUTF8Str)] string url, int flags, AVDictionary** options);
    public unsafe record struct AVFormatContext_io_open_func(IntPtr Pointer)
    {
        public static implicit operator AVFormatContext_io_open_func(AVFormatContext_io_open func) => new(func switch
        {
            null => IntPtr.Zero,
            _ => Marshal.GetFunctionPointerForDelegate(func)
        });
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate void AVFormatContext_io_close (AVFormatContext* s, AVIOContext* pb);
    public unsafe record struct AVFormatContext_io_close_func(IntPtr Pointer)
    {
        public static implicit operator AVFormatContext_io_close_func(AVFormatContext_io_close func) => new(func switch
        {
            null => IntPtr.Zero,
            _ => Marshal.GetFunctionPointerForDelegate(func)
        });
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate int AVOutputFormat_write_header (AVFormatContext* p0);
    public unsafe record struct AVOutputFormat_write_header_func(IntPtr Pointer)
    {
        public static implicit operator AVOutputFormat_write_header_func(AVOutputFormat_write_header func) => new(func switch
        {
            null => IntPtr.Zero,
            _ => Marshal.GetFunctionPointerForDelegate(func)
        });
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate int AVOutputFormat_write_packet (AVFormatContext* p0, AVPacket* pkt);
    public unsafe record struct AVOutputFormat_write_packet_func(IntPtr Pointer)
    {
        public static implicit operator AVOutputFormat_write_packet_func(AVOutputFormat_write_packet func) => new(func switch
        {
            null => IntPtr.Zero,
            _ => Marshal.GetFunctionPointerForDelegate(func)
        });
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate int AVOutputFormat_write_trailer (AVFormatContext* p0);
    public unsafe record struct AVOutputFormat_write_trailer_func(IntPtr Pointer)
    {
        public static implicit operator AVOutputFormat_write_trailer_func(AVOutputFormat_write_trailer func) => new(func switch
        {
            null => IntPtr.Zero,
            _ => Marshal.GetFunctionPointerForDelegate(func)
        });
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate int AVOutputFormat_interleave_packet (AVFormatContext* p0, AVPacket* @out, AVPacket* @in, int flush);
    public unsafe record struct AVOutputFormat_interleave_packet_func(IntPtr Pointer)
    {
        public static implicit operator AVOutputFormat_interleave_packet_func(AVOutputFormat_interleave_packet func) => new(func switch
        {
            null => IntPtr.Zero,
            _ => Marshal.GetFunctionPointerForDelegate(func)
        });
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate int AVOutputFormat_query_codec (AVCodecID id, int std_compliance);
    public unsafe record struct AVOutputFormat_query_codec_func(IntPtr Pointer)
    {
        public static implicit operator AVOutputFormat_query_codec_func(AVOutputFormat_query_codec func) => new(func switch
        {
            null => IntPtr.Zero,
            _ => Marshal.GetFunctionPointerForDelegate(func)
        });
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate void AVOutputFormat_get_output_timestamp (AVFormatContext* s, int stream, long* dts, long* wall);
    public unsafe record struct AVOutputFormat_get_output_timestamp_func(IntPtr Pointer)
    {
        public static implicit operator AVOutputFormat_get_output_timestamp_func(AVOutputFormat_get_output_timestamp func) => new(func switch
        {
            null => IntPtr.Zero,
            _ => Marshal.GetFunctionPointerForDelegate(func)
        });
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate int AVOutputFormat_control_message (AVFormatContext* s, int type, void* data, ulong data_size);
    public unsafe record struct AVOutputFormat_control_message_func(IntPtr Pointer)
    {
        public static implicit operator AVOutputFormat_control_message_func(AVOutputFormat_control_message func) => new(func switch
        {
            null => IntPtr.Zero,
            _ => Marshal.GetFunctionPointerForDelegate(func)
        });
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate int AVOutputFormat_write_uncoded_frame (AVFormatContext* p0, int stream_index, AVFrame** frame, uint flags);
    public unsafe record struct AVOutputFormat_write_uncoded_frame_func(IntPtr Pointer)
    {
        public static implicit operator AVOutputFormat_write_uncoded_frame_func(AVOutputFormat_write_uncoded_frame func) => new(func switch
        {
            null => IntPtr.Zero,
            _ => Marshal.GetFunctionPointerForDelegate(func)
        });
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate int AVOutputFormat_get_device_list (AVFormatContext* s, AVDeviceInfoList* device_list);
    public unsafe record struct AVOutputFormat_get_device_list_func(IntPtr Pointer)
    {
        public static implicit operator AVOutputFormat_get_device_list_func(AVOutputFormat_get_device_list func) => new(func switch
        {
            null => IntPtr.Zero,
            _ => Marshal.GetFunctionPointerForDelegate(func)
        });
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate int AVOutputFormat_create_device_capabilities (AVFormatContext* s, AVDeviceCapabilitiesQuery* caps);
    public unsafe record struct AVOutputFormat_create_device_capabilities_func(IntPtr Pointer)
    {
        public static implicit operator AVOutputFormat_create_device_capabilities_func(AVOutputFormat_create_device_capabilities func) => new(func switch
        {
            null => IntPtr.Zero,
            _ => Marshal.GetFunctionPointerForDelegate(func)
        });
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate int AVOutputFormat_free_device_capabilities (AVFormatContext* s, AVDeviceCapabilitiesQuery* caps);
    public unsafe record struct AVOutputFormat_free_device_capabilities_func(IntPtr Pointer)
    {
        public static implicit operator AVOutputFormat_free_device_capabilities_func(AVOutputFormat_free_device_capabilities func) => new(func switch
        {
            null => IntPtr.Zero,
            _ => Marshal.GetFunctionPointerForDelegate(func)
        });
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate int AVOutputFormat_init (AVFormatContext* p0);
    public unsafe record struct AVOutputFormat_init_func(IntPtr Pointer)
    {
        public static implicit operator AVOutputFormat_init_func(AVOutputFormat_init func) => new(func switch
        {
            null => IntPtr.Zero,
            _ => Marshal.GetFunctionPointerForDelegate(func)
        });
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate void AVOutputFormat_deinit (AVFormatContext* p0);
    public unsafe record struct AVOutputFormat_deinit_func(IntPtr Pointer)
    {
        public static implicit operator AVOutputFormat_deinit_func(AVOutputFormat_deinit func) => new(func switch
        {
            null => IntPtr.Zero,
            _ => Marshal.GetFunctionPointerForDelegate(func)
        });
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate int AVOutputFormat_check_bitstream (AVFormatContext* p0, AVPacket* pkt);
    public unsafe record struct AVOutputFormat_check_bitstream_func(IntPtr Pointer)
    {
        public static implicit operator AVOutputFormat_check_bitstream_func(AVOutputFormat_check_bitstream func) => new(func switch
        {
            null => IntPtr.Zero,
            _ => Marshal.GetFunctionPointerForDelegate(func)
        });
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate int av_format_get_control_message_cb (AVFormatContext* s, int type, void* data, ulong data_size);
    public unsafe record struct av_format_get_control_message_cb_func(IntPtr Pointer)
    {
        public static implicit operator av_format_get_control_message_cb_func(av_format_get_control_message_cb func) => new(func switch
        {
            null => IntPtr.Zero,
            _ => Marshal.GetFunctionPointerForDelegate(func)
        });
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate int av_format_set_control_message_cb_callback (AVFormatContext* s, int type, void* data, ulong data_size);
    public unsafe record struct av_format_set_control_message_cb_callback_func(IntPtr Pointer)
    {
        public static implicit operator av_format_set_control_message_cb_callback_func(av_format_set_control_message_cb_callback func) => new(func switch
        {
            null => IntPtr.Zero,
            _ => Marshal.GetFunctionPointerForDelegate(func)
        });
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate int av_format_get_open_cb (AVFormatContext* s, AVIOContext** pb, [MarshalAs(UnmanagedType.LPUTF8Str)] string url, int flags, AVIOInterruptCB* int_cb, AVDictionary** options);
    public unsafe record struct av_format_get_open_cb_func(IntPtr Pointer)
    {
        public static implicit operator av_format_get_open_cb_func(av_format_get_open_cb func) => new(func switch
        {
            null => IntPtr.Zero,
            _ => Marshal.GetFunctionPointerForDelegate(func)
        });
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate int av_format_set_open_cb_callback (AVFormatContext* s, AVIOContext** pb, [MarshalAs(UnmanagedType.LPUTF8Str)] string url, int flags, AVIOInterruptCB* int_cb, AVDictionary** options);
    public unsafe record struct av_format_set_open_cb_callback_func(IntPtr Pointer)
    {
        public static implicit operator av_format_set_open_cb_callback_func(av_format_set_open_cb_callback func) => new(func switch
        {
            null => IntPtr.Zero,
            _ => Marshal.GetFunctionPointerForDelegate(func)
        });
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate int avio_alloc_context_read_packet (void* opaque, byte* buf, int buf_size);
    public unsafe record struct avio_alloc_context_read_packet_func(IntPtr Pointer)
    {
        public static implicit operator avio_alloc_context_read_packet_func(avio_alloc_context_read_packet func) => new(func switch
        {
            null => IntPtr.Zero,
            _ => Marshal.GetFunctionPointerForDelegate(func)
        });
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate int avio_alloc_context_write_packet (void* opaque, byte* buf, int buf_size);
    public unsafe record struct avio_alloc_context_write_packet_func(IntPtr Pointer)
    {
        public static implicit operator avio_alloc_context_write_packet_func(avio_alloc_context_write_packet func) => new(func switch
        {
            null => IntPtr.Zero,
            _ => Marshal.GetFunctionPointerForDelegate(func)
        });
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate long avio_alloc_context_seek (void* opaque, long offset, int whence);
    public unsafe record struct avio_alloc_context_seek_func(IntPtr Pointer)
    {
        public static implicit operator avio_alloc_context_seek_func(avio_alloc_context_seek func) => new(func switch
        {
            null => IntPtr.Zero,
            _ => Marshal.GetFunctionPointerForDelegate(func)
        });
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate int AVFilter_preinit (AVFilterContext* ctx);
    public unsafe record struct AVFilter_preinit_func(IntPtr Pointer)
    {
        public static implicit operator AVFilter_preinit_func(AVFilter_preinit func) => new(func switch
        {
            null => IntPtr.Zero,
            _ => Marshal.GetFunctionPointerForDelegate(func)
        });
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate int AVFilter_init (AVFilterContext* ctx);
    public unsafe record struct AVFilter_init_func(IntPtr Pointer)
    {
        public static implicit operator AVFilter_init_func(AVFilter_init func) => new(func switch
        {
            null => IntPtr.Zero,
            _ => Marshal.GetFunctionPointerForDelegate(func)
        });
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate int AVFilter_init_dict (AVFilterContext* ctx, AVDictionary** options);
    public unsafe record struct AVFilter_init_dict_func(IntPtr Pointer)
    {
        public static implicit operator AVFilter_init_dict_func(AVFilter_init_dict func) => new(func switch
        {
            null => IntPtr.Zero,
            _ => Marshal.GetFunctionPointerForDelegate(func)
        });
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate void AVFilter_uninit (AVFilterContext* ctx);
    public unsafe record struct AVFilter_uninit_func(IntPtr Pointer)
    {
        public static implicit operator AVFilter_uninit_func(AVFilter_uninit func) => new(func switch
        {
            null => IntPtr.Zero,
            _ => Marshal.GetFunctionPointerForDelegate(func)
        });
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate int AVFilter_query_formats (AVFilterContext* p0);
    public unsafe record struct AVFilter_query_formats_func(IntPtr Pointer)
    {
        public static implicit operator AVFilter_query_formats_func(AVFilter_query_formats func) => new(func switch
        {
            null => IntPtr.Zero,
            _ => Marshal.GetFunctionPointerForDelegate(func)
        });
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate int AVFilter_process_command (AVFilterContext* p0, [MarshalAs(UnmanagedType.LPUTF8Str)] string cmd, [MarshalAs(UnmanagedType.LPUTF8Str)] string arg, byte* res, int res_len, int flags);
    public unsafe record struct AVFilter_process_command_func(IntPtr Pointer)
    {
        public static implicit operator AVFilter_process_command_func(AVFilter_process_command func) => new(func switch
        {
            null => IntPtr.Zero,
            _ => Marshal.GetFunctionPointerForDelegate(func)
        });
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate int AVFilter_init_opaque (AVFilterContext* ctx, void* opaque);
    public unsafe record struct AVFilter_init_opaque_func(IntPtr Pointer)
    {
        public static implicit operator AVFilter_init_opaque_func(AVFilter_init_opaque func) => new(func switch
        {
            null => IntPtr.Zero,
            _ => Marshal.GetFunctionPointerForDelegate(func)
        });
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate int AVFilter_activate (AVFilterContext* ctx);
    public unsafe record struct AVFilter_activate_func(IntPtr Pointer)
    {
        public static implicit operator AVFilter_activate_func(AVFilter_activate func) => new(func switch
        {
            null => IntPtr.Zero,
            _ => Marshal.GetFunctionPointerForDelegate(func)
        });
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate int func (AVFilterContext* ctx, void* arg, int jobnr, int nb_jobs);
    public unsafe record struct func_func(IntPtr Pointer)
    {
        public static implicit operator func_func(func func) => new(func switch
        {
            null => IntPtr.Zero,
            _ => Marshal.GetFunctionPointerForDelegate(func)
        });
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate int AVFilterGraph_execute (AVFilterContext* ctx, func_func func, void* arg, int* ret, int nb_jobs);
    public unsafe record struct AVFilterGraph_execute_func(IntPtr Pointer)
    {
        public static implicit operator AVFilterGraph_execute_func(AVFilterGraph_execute func) => new(func switch
        {
            null => IntPtr.Zero,
            _ => Marshal.GetFunctionPointerForDelegate(func)
        });
    }
}
