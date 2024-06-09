import React from 'react';
import Sidebar from '../../components/proSidebar'; 
import Map from '../../components/Map';
import '../../styles/dashboard.css';

const proDashboard = () => {
    return (
        <div className="dashboard">
            <Sidebar />
            <div className="main-content">
                <Map />
            </div>
        </div>
    );
};

export default proDashboard;
