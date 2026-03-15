import { Outlet } from 'react-router-dom';
const AdminLayout = () => {
  return (
    <div className="flex min-h-screen bg-gray-100">
      <aside className="w-64 bg-slate-900 text-white p-6">Sidebar Admin (Quản lý Đơn, Kho)</aside>
      <main className="flex-1 p-10">
        <header className="mb-8 border-b pb-4 font-bold text-2xl">Hệ thống Quản trị Dn_Cam</header>
        <Outlet />
      </main>
    </div>
  );
};
export default AdminLayout;