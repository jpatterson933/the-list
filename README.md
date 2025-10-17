# LA Adventures List - Spanish Style Website

A beautiful Spanish-themed website displaying adventure lists, built with C# ASP.NET Core.

## Features

- 🔐 Password-protected access
- 🎨 Spanish-inspired design with terracotta, red, and gold colors
- 📱 Responsive layout
- ✨ Animated hover effects

## Railway Deployment

### Setup Instructions

1. **Push to GitHub:**
   ```bash
   git add .
   git commit -m "Initial Spanish list website"
   git push origin jpatterson933/la-adventures-list
   ```

2. **Deploy on Railway:**
   - Go to [railway.app](https://railway.app)
   - Create new project
   - Connect your GitHub repository
   - Railway will auto-detect the Dockerfile or use nixpacks.toml

3. **Set Environment Variable:**
   In Railway dashboard:
   - Go to your project → Variables
   - Add: `SECRET_PASSWORD` = `your_chosen_password`

4. **Done!**
   Railway will automatically deploy. Visit your Railway URL and enter your password.

## Local Development

```bash
dotnet run
```

Visit: `https://localhost:5001`

Default password (local): `change_me_in_production`

## Environment Variables

- `SECRET_PASSWORD`: The password required to access the site (required in production)
- `PORT`: Automatically set by Railway
