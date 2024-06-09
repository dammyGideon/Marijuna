/* src/views/Onboarding.js */

import React, { useState, useEffect } from 'react';
import { FontAwesomeIcon } from '@fortawesome/react-fontawesome';
import {
  faSpinner,
  faCircleCheck,
  faCircleXmark,
  faCirclePause,
} from '@fortawesome/free-solid-svg-icons';
import InputField from '../components/InputField';
import Button from '../components/Button';
import { counties, states } from '../utils/constant';
import '../styles/Onboarding.css'; // Importing the specific CSS for this component
import { Link } from 'react-router-dom';

const logoIcon = require('../assets/images/herbzhub_icon_152030.png');
const logoText = require('../assets/images/herbzhub_text_152030.png');

const Onboarding = () => {
  const [organizationType, setOrganizationType] = useState('');
  const [county, setCounty] = useState('');
  const [serialNumber, setSerialNumber] = useState('');
  const [step, setStep] = useState(1);
  const [formData, setFormData] = useState({
    firstName: '',
    lastName: '',
    phoneNumber: '',
    email: '',
    address: '',
    city: '',
    state: '',
    zip: '',
    organizationName: '',
    dbaName: '',
    federalLicenseNumber: '',
    stateLicenseNumber: '',
    licenseExpiryDate: '',
    businessName: '',
    businessType: '',
    ownerName: '',
    ownerContact: '',
    numberOfEmployees: '',
    businessRegistrationNumber: '',
    annualRevenue: '',
    businessAddress: '',
    businessCity: '',
    businessState: '',
    businessZipCode: '',
    businessCountry: '',
    businessPhone: '',
    businessEmail: '',
    websiteURL: '',
    socialMediaProfiles: '',
    operatingHours: '',
    taxID: '',
    bankAccountNumber: '',
    bankName: '',
    username: '',
    password: '',
    confirmPassword: '',
  });
  const [idPhoto, setIdPhoto] = useState(null);
  const [licensePhoto, setLicensePhoto] = useState(null);
  const [verificationStatus, setVerificationStatus] = useState(
    'ID verification in progress'
  );
  const [federalLicenseStatus, setFederalLicenseStatus] = useState('ready');
  const [stateLicenseStatus, setStateLicenseStatus] = useState('ready');

  const handleOrganizationTypeSubmit = (event) => {
    event.preventDefault();
    setStep(2);
  };

  const handleCountySubmit = (event) => {
    event.preventDefault();
    setStep(3);
  };

  const handleSerialNumberSubmit = (event) => {
    event.preventDefault();
    setStep(4);
  };

  const handlePocFormSubmit = (event) => {
    event.preventDefault();
    setStep(4.5);
  };

  const handleVerificationSubmit = (event) => {
    event.preventDefault();
    if (idPhoto) {
      setVerificationStatus('ID verified');
    } else {
      setVerificationStatus('ID not verified');
    }
    setStep(5);
  };

  const handleOrganizationFormSubmit = (event) => {
    event.preventDefault();
    setStep(6);
  };

  const handleCredentialsSubmit = (event) => {
    event.preventDefault();
    // Add logic to handle final form submission
  };

  const handleInputChange = (e) => {
    const { name, value } = e.target;
    setFormData({
      ...formData,
      [name]: value,
    });
    if (name === 'serialNumber') {
      setSerialNumber(value);
    }
  };

  const handleFileChange = (e) => {
    setIdPhoto(e.target.files[0]);
  };

  const handleLicenseFileChange = (e) => {
    setLicensePhoto(e.target.files[0]);
  };

  useEffect(() => {
    const validateLicense = async (licenseNumber, setStatus) => {
      if (!licenseNumber) return;
      setStatus('loading');

      // Simulate API call
      setTimeout(() => {
        if (licenseNumber === 'VALID') {
          setStatus('valid');
        } else {
          setStatus('invalid');
        }
      }, 2000);
    };

    validateLicense(formData.federalLicenseNumber, setFederalLicenseStatus);
    validateLicense(formData.stateLicenseNumber, setStateLicenseStatus);
  }, [formData.federalLicenseNumber, formData.stateLicenseNumber]);

  const getStatusIcon = (status) => {
    switch (status) {
      case 'loading':
        return <FontAwesomeIcon icon={faSpinner} spinPulse />;
      case 'valid':
        return <FontAwesomeIcon icon={faCircleCheck} />;
      case 'invalid':
        return <FontAwesomeIcon icon={faCircleXmark} />;
      case 'ready':
      default:
        return <FontAwesomeIcon icon={faCirclePause} />;
    }
  };

  return (
    <div className="onboarding-page">
      <div className="header">
        <div className="logo-text">
          <img src={logoText} alt="HerbzHub Text Logo" />
        </div>
        <div className="sign-in-link">
          Already have an account?&nbsp;<Link to="/signin"> Sign In.</Link>
        </div>
      </div>
      <div className="onboarding-form">
        <div className="logo-top">
          <img src={logoIcon} alt="HerbzHub Logo" />
        </div>
        <h1 className="form-title">Welcome to HerbzHub!</h1>
        {step === 1 && (
          <p className="form-subtitle">Select your organization's type</p>
        )}
        {step === 1 && (
          <form onSubmit={handleOrganizationTypeSubmit}>
            <select
              value={organizationType}
              onChange={(e) => setOrganizationType(e.target.value)}
              required
              className="select-field"
            >
              <option value="" disabled selected>
                Select your Organization type
              </option>
              <option value="manufacturer">Manufacturer</option>
              <option value="dispensary">Dispensary</option>
            </select>
            <Button className="button" type="submit">
              Continue
            </Button>
          </form>
        )}
        {step === 2 && (
          <form onSubmit={handleCountySubmit}>
            <label className="form-subtitle">
              Select your organization's country
            </label>
            <select
              value={county}
              onChange={(e) => setCounty(e.target.value)}
              required
              className="select-field"
              placeholder="Select your organization country"
            >
              {counties.map((county, index) => (
                <option key={index} value={county}>
                  {county}
                </option>
              ))}
            </select>
            <Button className="button" type="submit">
              Continue
            </Button>
          </form>
        )}
        {step === 3 && (
          <form onSubmit={handleSerialNumberSubmit}>
            <label>Enter your device's serial number</label>
            <InputField
              type="text"
              placeholder="Serial Number"
              name="serialNumber"
              value={serialNumber}
              onChange={handleInputChange}
              required
            />
            <Button type="submit" className="button">
              Submit
            </Button>
          </form>
        )}
        {step === 4 && (
          <form onSubmit={handlePocFormSubmit}>
            <h3>Organization Representative Information</h3>
            <label>Enter your personal information.</label>
            <label>
              This information will be used for identification verification.
            </label>
            <div className="input-pair">
              <InputField
                type="text"
                placeholder="First Name"
                name="firstName"
                value={formData.firstName}
                onChange={handleInputChange}
                required
              />
              <InputField
                type="text"
                placeholder="Last Name"
                name="lastName"
                value={formData.lastName}
                onChange={handleInputChange}
                required
              />
            </div>
            <div className="input-pair">
              <InputField
                type="text"
                placeholder="Phone Number"
                name="phoneNumber"
                value={formData.phoneNumber}
                onChange={handleInputChange}
                required
              />
              <InputField
                type="email"
                placeholder="E-Mail"
                name="email"
                value={formData.email}
                onChange={handleInputChange}
                required
                pattern="[a-z0-9._%+-]+@[a-z0-9.-]+\.[a-z]{2,4}$"
              />
            </div>
            <div className="input-pair">
              <InputField
                type="text"
                placeholder="Address"
                name="address"
                value={formData.address}
                onChange={handleInputChange}
                required
              />
              <InputField
                type="text"
                placeholder="City"
                name="city"
                value={formData.city}
                onChange={handleInputChange}
                required
              />
            </div>
            <div className="input-pair">
              <select
                name="state"
                value={formData.state}
                onChange={handleInputChange}
                required
                className="select-field"
              >
                <option value="">Select State</option>
                {states.map((state, index) => (
                  <option key={index} value={state}>
                    {state}
                  </option>
                ))}
              </select>
              <InputField
                type="text"
                placeholder="Zip"
                name="zip"
                value={formData.zip}
                onChange={handleInputChange}
                required
              />
            </div>
            <Button type="submit" className="button">
              Continue
            </Button>
          </form>
        )}
        {step === 4.5 && (
          <form onSubmit={handleVerificationSubmit}>
            <label>Upload a photo of your ID</label>
            <input
              type="file"
              onChange={handleFileChange}
              accept="image/*"
              required
              className="input-field"
            />
            <div
              className={`status-bubble ${verificationStatus
                .replace(/\s+/g, '-')
                .toLowerCase()}`}
            >
              {verificationStatus}
            </div>
            <br />
            <Button type="submit" className="button">
              Submit
            </Button>
          </form>
        )}
        {step === 5 && (
          <form onSubmit={handleOrganizationFormSubmit}>
            <h3>
              {organizationType === 'manufacturer'
                ? 'Manufacturer Organization Information'
                : 'Dispensary Organization Information'}
            </h3>
            <label>Enter your organization information.</label>
            <h4>Licensing and Regulatory Compliance</h4>
            <div className="input-pair">
              <InputField
                type="text"
                placeholder="Federal License Number"
                name="federalLicenseNumber"
                value={formData.federalLicenseNumber}
                onChange={handleInputChange}
              />
              <div className="license-check">
                <InputField
                  type="text"
                  placeholder="State License Number"
                  name="stateLicenseNumber"
                  value={formData.stateLicenseNumber}
                  onChange={handleInputChange}
                />
                <div className="license-status">
                  {getStatusIcon(stateLicenseStatus)}
                </div>
              </div>
            </div>
            <div className="input-pair">
              <InputField
                type="date"
                placeholder="License Expiry Date"
                name="licenseExpiryDate"
                value={formData.licenseExpiryDate}
                onChange={handleInputChange}
              />
            </div>
            <label>Upload a copy of your license</label>
            <input
              type="file"
              onChange={handleLicenseFileChange}
              accept="image/*"
            />
            <h4>Business Details</h4>
            <div className="input-pair">
              <InputField
                type="text"
                placeholder="Business Name"
                name="businessName"
                value={formData.businessName}
                onChange={handleInputChange}
                //required
              />
              <InputField
                type="text"
                placeholder="Business Type"
                name="businessType"
                value={formData.businessType}
                onChange={handleInputChange}
                //required
              />
            </div>
            <div className="input-pair">
              <InputField
                type="text"
                placeholder="Owner Name"
                name="ownerName"
                value={formData.ownerName}
                onChange={handleInputChange}
                //required
              />
              <InputField
                type="text"
                placeholder="Owner Contact"
                name="ownerContact"
                value={formData.ownerContact}
                onChange={handleInputChange}
                //required
              />
            </div>
            <div className="input-pair">
              <InputField
                type="number"
                placeholder="Number of Employees"
                name="numberOfEmployees"
                value={formData.numberOfEmployees}
                onChange={handleInputChange}
                //required
              />
              <InputField
                type="text"
                placeholder="Business Registration Number"
                name="businessRegistrationNumber"
                value={formData.businessRegistrationNumber}
                onChange={handleInputChange}
                //required
              />
            </div>
            <div className="input-pair">
              <InputField
                type="number"
                placeholder="Annual Revenue"
                name="annualRevenue"
                value={formData.annualRevenue}
                onChange={handleInputChange}
                //required
              />
            </div>
            <h4>Location and Contact Information</h4>
            <div className="input-pair">
              <InputField
                type="text"
                placeholder="Business Address"
                name="businessAddress"
                value={formData.businessAddress}
                onChange={handleInputChange}
                //required
              />
              <InputField
                type="text"
                placeholder="Business City"
                name="businessCity"
                value={formData.businessCity}
                onChange={handleInputChange}
                //required
              />
            </div>
            <div className="input-pair">
              <select
                name="businessState"
                value={formData.businessState}
                onChange={handleInputChange}
                //required
              >
                <option value="">Select State</option>
                {states.map((state, index) => (
                  <option key={index} value={state}>
                    {state}
                  </option>
                ))}
              </select>
              <InputField
                type="text"
                placeholder="Business Zip Code"
                name="businessZipCode"
                value={formData.businessZipCode}
                onChange={handleInputChange}
                //required
                //pattern="[0-9]{5}"
              />
            </div>
            <div className="input-pair">
              <InputField
                type="text"
                placeholder="Business Country"
                name="businessCountry"
                value={formData.businessCountry}
                onChange={handleInputChange}
                //required
              />
            </div>
            <div className="input-pair">
              <InputField
                type="text"
                placeholder="Business Phone"
                name="businessPhone"
                value={formData.businessPhone}
                onChange={handleInputChange}
                //required
                //pattern="[0-9]{10}"
              />
              <InputField
                type="email"
                placeholder="Business Email"
                name="businessEmail"
                value={formData.businessEmail}
                onChange={handleInputChange}
                //required
                //pattern="[a-z0-9._%+-]+@[a-z0-9.-]+\.[a-z]{2,4}$"
              />
            </div>
            <div className="input-pair">
              <InputField
                type="text"
                placeholder="Website URL"
                name="websiteURL"
                value={formData.websiteURL}
                onChange={handleInputChange}
              />
              <InputField
                type="text"
                placeholder="Social Media Profiles"
                name="socialMediaProfiles"
                value={formData.socialMediaProfiles}
                onChange={handleInputChange}
              />
            </div>
            <h4>Operational Information</h4>
            <div className="input-pair">
              <InputField
                type="text"
                placeholder="Operating Hours"
                name="operatingHours"
                value={formData.operatingHours}
                onChange={handleInputChange}
                //required
              />
            </div>
            <h4>Financial Information</h4>
            <div className="input-pair">
              <InputField
                type="text"
                placeholder="Tax ID"
                name="taxID"
                value={formData.taxID}
                onChange={handleInputChange}
                //required
              />
              <InputField
                type="text"
                placeholder="Bank Account Number"
                name="bankAccountNumber"
                value={formData.bankAccountNumber}
                onChange={handleInputChange}
                //required
              />
            </div>
            <div className="input-pair">
              <InputField
                type="text"
                placeholder="Bank Name"
                name="bankName"
                value={formData.bankName}
                onChange={handleInputChange}
                //required
              />
            </div>
            <Button type="submit">Submit</Button>
          </form>
        )}
        {step === 6 && (
          <form onSubmit={handleCredentialsSubmit}>
            <h3>Create Your Account</h3>
            <div className="input-pair">
              <InputField
                type="email"
                placeholder="Username (Email)"
                name="username"
                value={formData.username}
                onChange={handleInputChange}
                required
                pattern="[a-z0-9._%+-]+@[a-z0-9.-]+\.[a-z]{2,4}$"
              />
            </div>
            <div className="input-pair">
              <InputField
                type="password"
                placeholder="Password"
                name="password"
                value={formData.password}
                onChange={handleInputChange}
                required
              />
            </div>
            <div className="input-pair">
              <InputField
                type="password"
                placeholder="Confirm Password"
                name="confirmPassword"
                value={formData.confirmPassword}
                onChange={handleInputChange}
                required
              />
            </div>
            <Button type="submit">Create Account</Button>
          </form>
        )}
      </div>
    </div>
  );
};

export default Onboarding;