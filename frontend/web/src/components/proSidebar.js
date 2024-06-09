import React from 'react';
import { Link } from 'react-router-dom';
import '../styles/sidebar.css'; // Updated path

const Sidebar = () => {
    return (
        <div className="sidebar">
            <div className="logo">
                <img src="\src\assets\images\herbzhub_pro.png" alt="Pro Logo" />
            </div>
            <nav>
                <ul>
                    <li><Link to="/overview" className="nav-link">Overview</Link></li>
                    <li><Link to="/assets" className="nav-link">Assets</Link></li>
                    <li><Link to="/purchase-orders" className="nav-link">Purchase Orders</Link></li>
                    <li><Link to="/inventory" className="nav-link">Inventory</Link></li>
                    <li><Link to="/dispatch" className="nav-link">Dispatch</Link></li>
                    <li><Link to="/safety" className="nav-link">Safety</Link></li>
                    <li><Link to="/documents" className="nav-link">Documents</Link></li>
                    <li><Link to="/reports" className="nav-link">Reports</Link></li>
                </ul>
            </nav>
        </div>
    );
};

export default Sidebar;
