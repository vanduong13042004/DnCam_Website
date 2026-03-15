import { ShieldCheck, Play } from 'lucide-react';
import cameraImg from '../assets/image.png'; 
const HeroBanner = () => {
  return (
    <section className="bg-indigo-900 text-white py-16 lg:py-24 relative overflow-hidden">
      <div className="container mx-auto px-4 lg:px-8 flex flex-col lg:flex-row items-center gap-12">
        
        <div className="w-full lg:w-1/2 z-10">
          <h1 className="text-4xl lg:text-6xl font-extrabold leading-tight mb-6">
            Bắt Trọn Từng <br />
            <span className="text-teal-400">Khoảnh Khắc Của Bạn</span>
          </h1>
          <p className="text-gray-300 text-lg mb-8 max-w-lg leading-relaxed">
            Khám phá bộ sưu tập máy ảnh hiện đại với công nghệ ống kính tiên tiến, 
            đảm bảo mang lại những bức ảnh sắc nét và chân thực nhất cho đam mê của bạn.
          </p>
          
          <div className="flex flex-col sm:flex-row gap-4 mb-12">
            <button className="bg-teal-500 hover:bg-teal-600 text-white px-8 py-4 rounded-lg font-bold transition-all shadow-lg shadow-teal-500/30">
              Khám Phá Sản Phẩm
            </button>
            <button className="border border-white/30 hover:bg-white hover:text-indigo-900 px-8 py-4 rounded-lg font-bold transition-all">
              Tư Vấn Miễn Phí
            </button>
          </div>
        </div>

        <div className="w-full lg:w-1/2 relative z-10 mt-10 lg:mt-0">
          <div className="relative rounded-2xl overflow-hidden shadow-2xl border-4 border-white/10">
            <img 
              src={cameraImg}
              alt="Người cầm máy ảnh" 
              className="w-full h-auto object-cover"
            />
            <div className="absolute inset-0 flex items-center justify-center">
              <button className="bg-white/20 backdrop-blur-md p-4 rounded-full hover:bg-white/40 transition-all">
                <Play className="w-12 h-12 text-white fill-white" />
              </button>
            </div>
          </div>
        </div>

      </div>
    </section>
  );
};

export default HeroBanner;