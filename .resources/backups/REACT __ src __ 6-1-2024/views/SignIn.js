// src/views/SignIn.js

import React, { useState } from 'react';
import { Link } from 'react-router-dom';
import InputField from '../components/InputField';
import Button from '../components/Button';
import '../styles/SignIn.css'; // Importing the specific CSS for this component

const logoIcon = require('../assets/images/herbzhub_icon_152030.png');
const logoText = require('../assets/images/herbzhub_text_152030.png');

const SignIn = () => {
  const [step, setStep] = useState(1);
  const [email, setEmail] = useState('');
  const [password, setPassword] = useState('');

  const handleContinue = (event) => {
    event.preventDefault();
    if (email) {
      setStep(2);
    }
  };

  const handleLogin = async (event) => {
    event.preventDefault();
    // Add sign in logic here
  };

  return (
    <div className="signin-page">
      <div className="signin-form">
        <div className="logo-icon">
          <img src={logoIcon} alt="HerbzHub Logo" />
        </div>
        <h1 className="form-title">Sign In</h1>
        {step === 1 ? (
          <>
            <p className="err-button">Invalid Email</p>
            <InputField
              type="email"
              placeholder="Name@Work-Email.com"
              value={email}
              onChange={(e) => setEmail(e.target.value)}
            />
            <Button
              className="button"
              onClick={handleContinue}
              disabled={!email}
            >
              Continue
            </Button>
          </>
        ) : (
          <>
            <p className="err-button">Invalid Password</p>
            <InputField
              type="email"
              placeholder="Name@Work-Email.com"
              value={email}
              onChange={(e) => setEmail(e.target.value)}
              disabled
            />
            <InputField
              type="password"
              placeholder="Password"
              value={password}
              onChange={(e) => setPassword(e.target.value)}
            />
            <Button className="button" onClick={handleLogin}>
              Sign In
            </Button>
          </>
        )}
        <div className="links">
          <div>
            <Link to="/onboarding">Complete Onboarding</Link>
          </div>
          <div>
            <Link to="/reset-password">Reset Password</Link>
          </div>
        </div>
        <div className="footer-links">
          <div className="bottom-links">
            <a href="/support">Support</a>&nbsp;<a href="/referral">Referral</a>
          </div>
        </div>
        <div className="logo-text">
          <img src={logoText} alt="HerbzHub Text" />
        </div>
      </div>
      <div className="signin-graphic">{/* Background graphic goes here */}</div>
    </div>
  );
};

export default SignIn;
