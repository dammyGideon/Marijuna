// src/views/ResetPassword.js

import React, { useState } from 'react';
import { Link } from 'react-router-dom';
import InputField from '../components/InputField';
import Button from '../components/Button';
import '../styles/ResetPassword.css';

const logoIcon = require('../assets/images/herbzhub_icon_152030.png');
const logoText = require('../assets/images/herbzhub_text_152030.png');

const ResetPassword = () => {
  const [email, setEmail] = useState('');
  const [requestSent, setRequestSent] = useState(false);

  const handleResetPassword = async (event) => {
    event.preventDefault();
    // Add reset password logic here
    setRequestSent(true);
  };

  return (
    <div className="reset-password-page">
      <div className="reset-password-form">
        <div className="logo-icon">
          <img src={logoIcon} alt="HerbzHub Logo" />
        </div>
        {requestSent ? (
          <>
            <h1 className="form-title">Password reset request received!</h1>
            <p className="instructions">
              We have received your password reset request. If an account with the email address you provided exists in our system, we will send you an email with instructions on how to reset your password. If you do not receive this email within twenty minutes, please contact HerbzHub’s Technical Support team for further assistance.
            </p>
            <Button className="button">
              <Link to="/signin">Return to Sign In</Link>
            </Button>
          </>
        ) : (
          <>
            <h1 className="form-title">Reset Password</h1>
            <p className="instructions">Enter your email to reset your password</p>
            <InputField
              type="email"
              placeholder="Name@Work-Email.com"
              value={email}
              onChange={(e) => setEmail(e.target.value)}
            />
            <Button
              className="button"
              onClick={handleResetPassword}
              disabled={!email}
            >
              Send Reset Link
            </Button>
          </>
        )}
        <div className="footer-links">
          <div className="bottom-links">
            <a href="/support">Support</a>&nbsp;<a href="/referral">Referral</a>
          </div>
        </div>
        <div className="logo-text">
          <img src={logoText} alt="HerbzHub Text" />
        </div>
      </div>
      <div className="reset-password-graphic">{/* Background graphic goes here */}</div>
    </div>
  );
};

export default ResetPassword;
